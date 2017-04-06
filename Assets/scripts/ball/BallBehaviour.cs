using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

    public float forceApplied = 50;
    public AudioSource bounce;
    public Material blue;
    public Material red;
    public Material yellow;
    public Material green;
    public Material redFlare;
    Renderer render;
    Rigidbody body;
    // Use this for initialization
    void Start()
    {
        render = GetComponent<Renderer>();
        body = GetComponent<Rigidbody>();
        StartCoroutine(startLight());
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Goal"))
        {
            StartCoroutine(splitMesh());
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.transform.tag == "Player")
        {
            Vector3 direction = col.transform.forward;
            direction.y = 1;

            gameObject.GetComponent<Rigidbody>().AddForce(direction * forceApplied);

            Instantiate(bounce, transform.position, transform.rotation);
            StartCoroutine(flash());            

        }

    }

    IEnumerator flash()
    {
        render.material = redFlare;
        yield return new WaitForSeconds(0.65f);
        render.material = blue;
    }

    IEnumerator startLight()
    {
        body.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        render.material = red;
        yield return new WaitForSeconds(1.5f);
        render.material = yellow;
        yield return new WaitForSeconds(1.5f);
        render.material = green;
        yield return new WaitForSeconds(1.5f);
        body.constraints = RigidbodyConstraints.None;
        render.material = blue;
    }

    IEnumerator splitMesh()
    {
        MeshFilter MF = GetComponent<MeshFilter>();
        MeshRenderer MR = GetComponent<MeshRenderer>();
        Mesh M = MF.mesh;
        Vector3[] verts = M.vertices;
        Vector3[] normals = M.normals;
        Vector2[] uvs = M.uv;
        for (int submesh = 0; submesh < M.subMeshCount; submesh++)
        {
            int[] indices = M.GetTriangles(submesh);
            for (int i = 0; i < indices.Length; i += 6)
            {
                Vector3[] newVerts = new Vector3[3];
                Vector3[] newNormals = new Vector3[3];
                Vector2[] newUvs = new Vector2[3];
                for (int n = 0; n < 3; n++)
                {
                    int index = indices[i + n];
                    newVerts[n] = verts[index];
                    newUvs[n] = uvs[index];
                    newNormals[n] = normals[index];
                }
                Mesh mesh = new Mesh();
                mesh.vertices = newVerts;
                mesh.normals = newNormals;
                mesh.uv = newUvs;

                mesh.triangles = new int[] { 0, 1, 2, 2, 1, 0 };

                GameObject GO = new GameObject("Triangle " + (i / 3));
                GO.transform.position = transform.position;
                GO.transform.rotation = transform.rotation;
                GO.AddComponent<MeshRenderer>().material = MR.materials[submesh];
                GO.AddComponent<MeshFilter>().mesh = mesh;
                GO.AddComponent<BoxCollider>();
                GO.AddComponent<Rigidbody>().AddExplosionForce(100, transform.position, 30);

                Destroy(GO, 5 + Random.Range(0.0f, 5.0f));
            }
        }
        MR.enabled = false;

        Time.timeScale = 0.2f;
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 1.0f;
        Destroy(gameObject);
    }
}

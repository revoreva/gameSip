var degress = 10;
var target : Transform;
function Update()
{
    //if(Object.e)
        transform.RotateAround (target.position, Vector3.forward, degress * Time.deltaTime);
}
#pragma strict

var speed:float = 5.0;

function Start () 
{

}
function Update () 
{
    var x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    var y = Input.GetAxis("UpDown") * speed * Time.deltaTime;
    var z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
    transform.Translate(x, y, z);
}
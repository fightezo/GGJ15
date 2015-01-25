#pragma strict

var c = false;

function Update () {
    if(c == true){
    Application.LoadLevel("ShopMenu");
}}

function OnCollisionEnter (collision : Collision){
   if ( collision.gameObject.name == "player2")
   c = true;
   }

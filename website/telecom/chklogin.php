<?php 

session_start();

$uname=$_POST["txtuname"];
$pass=$_POST["txtpass"];

include "connect.php";

$q="select * from login where uname='$uname' and pass='$pass'";



$res=mysql_query($q) or die("could not execute");

if(mysql_num_rows($res)>0)
{
$_SESSION['un']=$uname;
$_SESSION['pass']=$pass;
header("Location:temp2.php");
}

else
{
header("Location:index.php");
}

?>





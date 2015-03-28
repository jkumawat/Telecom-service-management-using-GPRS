<?php 
session_start();
if(!isset($_SESSION['un']))
{
header("Location:index.php");
}
?>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">







<html xmlns="http://www.w3.org/1999/xhtml">



<head>



<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />



<title>Jas Telecom Service Provider</title>


<style type="text/css">



<!--


a:link {
	color:=#FF0033;
}
body,td,th {



	color:#000000;
	
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size:12px;

}



body {



	


}



.style1 {



	color: #99FF33;


	font:Verdana
	font-weight: normal;



}
.style3 {color: #000000}
.style5 {color: #0066CC}
.style6 {color: #CC0000}



-->



</style></head>







<body>

<?php 	unlink("solved.txt"); ?>





      <table width="488" border="1" align="center" >



        <tr>



          <td><img src="banner.jpg" width="619" height="106" /></td>



        </tr>



        <tr>



          <td>

<?php

$name=$_GET['name'];
?>

	      <span class="style1"><span class="style3"><span class="style5">Today's Date</span>:</span>-</span> 
          <label><span class="style3"><?php echo  date("d-m-y");?></span></label>
          <span class="style3">&nbsp;&nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <span class="style6" >
          <label><?php echo"<a href=index.php>Signout</a>";?> 
		  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<?php
		  echo"<a href=temp2.php?un=$name>Back</a>";
 ?>
 </label>
          </span>
          <label></label></td>
       </tr>
        <tr>
          <td><p>

<?php


	include "connect.php";

	$name=$_SESSION['un'];
if ($_GET['cmp'] !="")

{
	$comp=$_GET['cmp'];
	echo $comp;
	$updq="update complain set status='Solved' where comp_no='$comp' and emp_no='$name'";
	$myres = mysql_query($updq) or die("Could not execute");

}	
//echo "Solved";
$q="SELECT * FROM complain where status='Solved' and emp_no='$name'";
$result = mysql_query($q) or die(mysql_error());
echo "<table border=1 cellspacing=0 cellpadding=0 align=center style='color:#000000'>";
while($row = mysql_fetch_array($result))
  {

$File = "solved.txt"; 
$Handle = fopen($File, 'a');
fwrite($Handle, $row[0]."@".$row[1]."|"); 



	echo "<tr  bgcolor=#0099FF>";
			echo "<td>";

		echo "Complain No.";

			echo "</td>";

		echo "<td>";

		echo $row[1];

			echo "</td>";

			echo "</tr>";

//////////////////////////////////
	echo "<tr >";

			echo "<td>";

		echo "Name";

			echo "</td>";

		echo "<td>";

		echo $row[2];

			echo "</td>";

			echo "</tr>";

			///////////////

			echo "<tr >";

			echo "<td>";

		echo "Address";

			echo "</td>";

		echo "<td>";

		echo $row[3];

			echo "</td>";

			echo "</tr>";

			

			

			////////

			

			echo "<tr >";

			echo "<td>";

		echo "Contact";

			echo "</td>";

		echo "<td>";

		echo $row[4];

			echo "</td>";

			echo "</tr>";

			

			////////

			

			echo "<tr >";

			echo "<td>";

		echo "Problem Type  ";
		

			echo "</td>";

		echo "<td>";

		echo $row[5];

			echo "</td>";

			echo "</tr>";
			///////////////////
			
			echo "<tr >";

			echo "<td>";

		echo "Priority  ";
		

			echo "</td>";

		echo "<td>";

		echo $row[6];

			echo "</td>";

			echo "</tr>";
			/////////////////////////
echo "<tr><td colspan=2>&nbsp;</td></tr>";
			
  }
echo "</table>";


?>          </p>         	  </td>



        </tr>



      </table>



      <p>&nbsp;</p>



      <p>&nbsp;</p>



      <p>&nbsp;</p>



      <p>&nbsp;</p>







</body>



</html>

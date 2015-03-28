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

<?php
	include "connect.php";
		$uname=$_SESSION['un'];
		$pass=$_SESSION['pass'];

$dir = ".";
$dh = opendir($dir);

while (($file = readdir($dh)) !== false) //1
{
			if ($file == "complain.txt")//2
			{
				$handle = fopen("complain.txt","r");
				if ($handle) //3
				{
					$t="truncate table complain";
					$res=mysql_query($t) or die("could not truncate");
					while (!feof($handle))//4 
					{
							$buffer = fgets($handle, 4096); 
							if(strlen(trim($buffer))>0)//5
							{
								$arr=explode("@",$buffer);
								$i="insert into complain values('$arr[0]','$arr[1]','$arr[2]','$arr[3]','$arr[4]','$arr[5]','$arr[6]','unsolved')";
								$inst=mysql_query($i) or die(mysql_error());

							}//5
					}//4
				}//3
		fclose($handle); 
		unlink("complain.txt");
	}//2
	$flag=0;
	
	
}//1
closedir($dh);
?>




      <table width="488" border="1" align="center" >



        <tr>



          <td><img src="banner.jpg" width="619" height="106" /></td>



        </tr>



        <tr>



          <td>

	      <span class="style1"><span class="style3"><span class="style5">Today's Date</span>:</span>-</span> 

          <label><span class="style3"><?php echo  date("d-m-y");?></span></label>
          <span class="style3">&nbsp;&nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <span class="style6" >
          <label><?php echo"<a href=logout.php>Signout</a>";?>
		  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		  <?php
		  $uname=$_SESSION['un']; 
		  echo"<a href=solve.php?name=$uname>Solved Problems!</a>";?>
		  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		  </label>
          </span>
          <label></label></td>
		



        </tr>



        <tr>



          <td><p>

<?php	
//fetch data
if ($flag==0)
{
$i=0;
$q="SELECT * FROM complain where emp_no='$uname' and status!='solved'";
$result = mysql_query($q) or die(mysql_error());
echo "<table border=1 cellspacing=0 cellpadding=0 align=center style='color:#000000'>";
while($row = mysql_fetch_array($result))
  {
  	$i=$i+1;
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
			echo "<tr >";
echo "<td>";

		
		

			echo "</td>";
		echo "<td >";

		echo "<a href=solve.php?cmp=$row[1]>Solve</a>";

			echo "</td>";

			echo "</tr>";
/////////////////////////////
echo "<tr><td colspan=2>&nbsp;</td></tr>";
  }
echo "</table>";
}
if ($i==0)
{
			echo "<tr >";
	echo "<td >";

		echo "NO MORE COMPLAINS!!!";

			echo "</td>";

			echo "</tr>";

}


?>

          </p>         	  </td>



        </tr>



      </table>



      <p>&nbsp;</p>



      <p>&nbsp;</p>



      <p>&nbsp;</p>



      <p>&nbsp;</p>







</body>



</html>
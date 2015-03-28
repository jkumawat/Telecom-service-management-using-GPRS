<?php
 session_start() ;
if(isset($_SESSION['name']))
    unset($_SESSION['name']); 
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Jas Telecom Service Provider</title>
<script type="text/JavaScript">
<!--
function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}

function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}

function MM_findObj(n, d) { //v4.01
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && d.getElementById) x=d.getElementById(n); return x;
}

function MM_swapImage() { //v3.0
  var i,j=0,x,a=MM_swapImage.arguments; document.MM_sr=new Array; for(i=0;i<(a.length-2);i+=3)
   if ((x=MM_findObj(a[i]))!=null){document.MM_sr[j++]=x; if(!x.oSrc) x.oSrc=x.src; x.src=a[i+2];}
}

function error()
{
//alert("please Fill Require fields!");
}


function validate()
	{
		
		if (document.frmlogin.txtuname.value == "" || document.frmlogin.txtpass.value == "")
			{
				//return false;
				document.frmlogin.txtuname.focus();
			}  
			else 
			{
					document.frmlogin.submit();
				//return true;
			}
}

//-->
</script>

<style type="text/css">
<!--
body,td,th {
	color: #000000;
	font-family: Verdana, Arial, Helvetica, sans-serif;
	font-size:12px;
}
body {
	
}
a:link {
	color: #0000FF;
}
a:visited {
	color: #993300;
}
a:hover {
	color: #00FFFF;
}
a:active {
	color: #FF0000;
}
.style6 {color: #000000}
.style7 {
	color: #0099FF;
	font-weight: bold;
}
.style8 {color: #0099FF}
.style9 {
	color: #0066CC;
	font-weight: bold;
}
-->
</style>


</head>

<body onload="MM_preloadImages('pic.jpg')">
<?php
		
	include "connect.php";
			
$dir = ".";
$dh = opendir($dir);
while (($file = readdir($dh)) !== false) 
{
if ($file == "employee.txt")
{
		$trn="truncate table login ";
		$res=mysql_query($trn) or die("can not insert");		
		
		$buffer="";
		$handle = fopen("employee.txt","r"); 
if ($handle) 
{
	while (!feof($handle)) 
	{
		$buffer = fgets($handle, 4096); 
		$arr=explode("@",$buffer);
		echo "<br>";
				echo "<br>";
				echo $arr[0];
				echo $arr[1];
		
		$in="INSERT INTO login values('$arr[0]','$arr[1]')";
		$res=mysql_query($in) or die("can not insert");	
	}
	
}
else
{
		echo "invalid";
}
unlink ("employee.txt");
}//if loop of file
else{

}
}

?>
  <table width="627" height="254" border="1" align="center" cellspacing="0" cellpadding="0">
    <tr>
      <td height="109" colspan="2"><img src="./banner.jpg" width="626" height="107" /></td>
    </tr>
    <tr>
      <td colspan="2"><strong><span class="style8">Today's Date:</span> 
          <label ><span class="style6"><?php echo Date("d-m-y");  ?></span></label>
      </strong></td>
    </tr>
    <tr>
      <td width="365" height="121" valign="middle" ><p class="style9">Welcome To , Jas telecom </p>
      <p class="style7">We are Service provider company,we are here to provide you a better solution and services.<span class="style7">Note for Employee:- &quot;Log in for Collecing the Complain Reports.      
	  </td>
      <td width="248" valign="middle" align="center">
		<div align="center">
        <form method="post" name="frmlogin"  action="chklogin.php" >
		<table border="1" cellpadding="0" cellspacing="0">
		<tr>
		<td valign="middle" align="center">
        <table width="248" height="113" border="0" align="center">
          <tr>
            <td colspan="2"><span class="style9">Login Information </span></td>
          </tr>
          <tr>
            <td><span class="style6">User Name </span>:</td>
            <td><label>
              
              <input name="txtuname" type="text" id="txtuname" />
            </label></td>
          </tr>
          <tr>
            <td><span class="style6">password :</span></td>
            <td><input name="txtpass" type="password" id="txtpass" /></td>
          </tr>
          
          <tr>
            <td>&nbsp;</td>
            <td><label>
              <input name="btnsub" type="submit" class="style7" id="btnsub"  value="Login" onclick="fun()"/>
              <input name="btncancel" type="reset" class="style7" id="btncancel" value="Cancel" />
            </label></td>
          </tr>
        </table>
		</td>
		</tr>
		</table>
	  </form></div></td>
    </tr>
</table>
  <p>&nbsp;</p>
</body>
</html>
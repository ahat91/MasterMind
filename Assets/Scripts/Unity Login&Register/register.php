<?PHP

$user = $_POST['user'];
$name = $_POST['name'];
$pass = $_POST['password'];

$con = mysql_connect("fdb3.awardspace.com","847508_admin","vacume") or ("Cannot connect!"  . mysql_error());
if (!$con)
	die('Could not connect: ' . mysql_error());
	
mysql_select_db("847508_admin" , $con) or die ("could not load the database" . mysql_error());

$check = mysql_query("SELECT * FROM unityTut WHERE `user`='".$user."'");
$numrows = mysql_num_rows($check);
if ($numrows == 0)
{
	$pass = md5($pass);
	$ins = mysql_query("INSERT INTO  `unityTut` (  `id` ,  `user` ,  `name` ,  `pass` ) VALUES ('' ,  '".$user."' ,  '".$name."' ,  '".$pass."') ; ");
	if ($ins)
		die ("Succesfully Created User!");
	else
		die ("Error: " . mysql_error());
}
else
{
	die("User allready exists!");
}


?>
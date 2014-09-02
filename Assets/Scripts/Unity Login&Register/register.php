<?PHP

$user = $_POST['user'];
$name = $_POST['name'];
$pass = $_POST['password'];

$con = mysql_connect("localhost","austinhatem","Bulkhead12-") or ("Cannot connect!"  . mysql_error());
if (!$con)
	die('Could not connect: ' . mysql_error());
	
mysql_select_db("MasterMindDB" , $con) or die ("could not load the database" . mysql_error());

$check = mysql_query("SELECT * FROM userBase WHERE `user`='".$user."'");
$numrows = mysql_num_rows($check);
if ($numrows == 0)
{
	$pass = md5($pass);
	$ins = mysql_query("INSERT INTO  `userBase` (  `userId` ,  `user` ,  `password` ) VALUES ('' ,  '".$user."' , '".$pass."') ; ");
	if ($ins)
		die ("Succesfully Created User!");
	else
		die ("Error: " . mysql_error());
}
else
{
	die("User already exists!");
}


?>
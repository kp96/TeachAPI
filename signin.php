<?php
$host = '';
$user = '';
$pass = '';
$dbname = '';
$username = $_POST["username"];
$userpass = $_POST["userpass"];
$link = mysqli_connect($host, $user, $pass);
if($link == NULL) {
	die(mysqli_error);
} else {
	mysqli_select_db($link, $dbname);
	$qstring = "SELECT * FROM USERS WHERE `username` = '$username' AND `password` = '$userpass'";
	$result = mysqli_query($link, $qstring);
	if (mysqli_num_rows($result) > 0) {
		echo "Correct username and password";
	} else {
    echo "Invalid Login";
	}
	mysqli_close($link);
}
?>

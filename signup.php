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
	$qstring = "INSERT INTO USERS VALUES('$username', '$userpass')";
	$result = mysqli_query($link, $qstring);
	if ($result) {
		echo "stored data successfully";
	} else {
    echo "Some error" . mysqli_error($link);
	}
	mysqli_close($link);
}
?>

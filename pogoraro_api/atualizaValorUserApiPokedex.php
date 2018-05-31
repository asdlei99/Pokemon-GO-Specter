<?php
$servername = "";
$username = "";
$password = "";
$dbname = "";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Falha na conexao: " . $conn->connect_error);
} 

$idStuff = explode(",", $_GET["variable"]);

$sql = "UPDATE users SET apiPokedex100 = '$idStuff[0]' WHERE id = '$idStuff[1]'";
$result = $conn->query($sql);
echo "$conn->affected_rows";

$conn->close();
?>
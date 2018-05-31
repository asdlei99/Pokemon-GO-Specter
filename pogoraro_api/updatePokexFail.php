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

$usuario = $_GET["id"];

$sql = "UPDATE discordTokens SET blocked = 1 WHERE token =$usuario";
$result = $conn->query($sql);
echo "$conn->affected_rows";

$conn->close();
?>
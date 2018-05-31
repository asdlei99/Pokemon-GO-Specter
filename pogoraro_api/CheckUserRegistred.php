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

$codPokemonRaro = $_GET["codigoCompra"];

$sql = "SELECT ID FROM wp_users WHERE user_email ='$codPokemonRaro'";
$result = $conn->query($sql);
echo "$conn->affected_rows";

$conn->close();
?>
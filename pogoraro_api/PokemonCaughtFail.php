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

$sql = "UPDATE users SET totalPokemonFlee=totalPokemonFlee+1 WHERE codigoCompra ='$codPokemonRaro'";
$result = $conn->query($sql);
echo "$conn->affected_rows";

$conn->close();
?>
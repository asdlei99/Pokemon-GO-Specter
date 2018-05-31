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

$sql = "UPDATE users SET totalPokemon='0' WHERE codigoCompra ='$codPokemonRaro'";
$result = $conn->query($sql);
echo "$conn->affected_rows";

$conn->close();
?>
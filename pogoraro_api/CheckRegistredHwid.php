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

$sql = "SELECT hwid FROM users WHERE hwid='$codPokemonRaro'";
$result = $conn->query($sql);
echo "$conn->affected_rows";

while($row = $result->fetch_assoc()) {
echo ",".$row["hwid"]."";
}


$conn->close();
?>
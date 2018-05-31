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

$numeroPedido = $_GET["numeroPedido"];
$codigoCompra = $_GET["codigoCompra"];
$hwid = $_GET["hwid"];

$pushPokemonDataQuery = "INSERT INTO users (numeroPedido,codigoCompra,totalPokemon,maxPokemon,iv100,active,totalPokemonFlee,freeUser,hwid) VALUES('$numeroPedido','$codigoCompra','0','1','0','2','0','1','$hwid')";

$result = $conn->query($pushPokemonDataQuery);

if ($conn->error) {
    try {    
        throw new Exception("MySQL error $mysqli->error <br> Query:<br> $pushPokemonDataQuery", $conn->errno);    
    } catch(Exception $e ) {
        echo "Error No: ".$e->getCode(). " - ". $e->getMessage() . "<br >";
        echo nl2br($e->getTraceAsString());
    }
}

echo "$conn->affected_rows";


$conn->close();
?>
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

$userId = $_GET["userId"];
$pNumber = $_GET["pNumber"];
$pNome = $_GET["pNome"];
$pInfo = $_GET["pInfo"];
$pLatitude = $_GET["pLatitude"];
$pLongitude = $_GET["pLongitude"];
$pTimeLeft = $_GET["pTimeLeft"];

$pushPokemonDataQuery = "INSERT INTO pokemonsCaptured (pokemonsCaptured.`userId`, pokemonsCaptured.`PNumber`, pokemonsCaptured.`PName`, pokemonsCaptured.`PInformation`, pokemonsCaptured.`PLatitude`, pokemonsCaptured.`PLongitude`, pokemonsCaptured.`PTimeCatch`) VALUES('$userId','$pNumber','$pNome','$pInfo','$pLatitude','$pLongitude','$pTimeLeft')";

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
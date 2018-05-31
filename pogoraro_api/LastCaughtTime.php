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

$usuario = $_GET["hash"];

$sql = "SELECT * FROM pokemonsCaptured WHERE userId= '$usuario' ORDER BY PTimeCatch DESC LIMIT 1";
$result = $conn->query($sql);

date_default_timezone_set('America/Sao_Paulo');
$date = date('Y-m-d h:i:s');


if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        echo "" . $row["PTimeCatch"]. ", ". $date ."";
    }
} else {
    echo "none";
}
$conn->close();
?>
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

$usuario = $_GET["codigoCompra"];

$sql = "SELECT * FROM users WHERE codigoCompra = '$usuario'";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        echo "".$row["active"].",".$row["iv100"].",".$row["freeUser"].",".$row["hwid"]."";
    }
} else {
    echo "none";
}
$conn->close();
?>
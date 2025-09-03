      CREATE DATABASE parqueadero;
      USE parqueadero;
     
CREATE TABLE carros (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Modelo VARCHAR(100) NOT NULL,
    Placa VARCHAR(20) NOT NULL UNIQUE,
    dueño VARCHAR(100) NOT NULL) ENGINE=InnoDB;
    
    CREATE TABLE personas (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Documento VARCHAR(50) NOT NULL UNIQUE,
    Telefono VARCHAR(20) NOT NULL) ENGINE=InnoDB;



select * from personas;


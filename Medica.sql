-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: medica
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `medico`
--

DROP TABLE IF EXISTS `medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medico` (
  `Doctor_id` int unsigned NOT NULL AUTO_INCREMENT,
  `Nombres` varchar(15) NOT NULL,
  `Apellido_Paterno` varchar(15) NOT NULL,
  `Apellido_Materno` varchar(15) NOT NULL,
  `Cedula_Profesional` int NOT NULL,
  `Especialidad` enum('Nutriología','Optometría','Odontología') NOT NULL,
  `Telefono` int NOT NULL,
  `CURP` varchar(18) NOT NULL,
  `RFC` varchar(13) NOT NULL,
  `Género` enum('Hombre','Mujer') NOT NULL,
  `Contraseña` varchar(20) NOT NULL,
  PRIMARY KEY (`Doctor_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medico`
--

LOCK TABLES `medico` WRITE;
/*!40000 ALTER TABLE `medico` DISABLE KEYS */;
INSERT INTO `medico` VALUES (1,'Luis','Gabriel','Rey',27635261,'Optometría',2017289918,'FGST783762FHSGTE01','AFD0111923U','Hombre','CONTRASEÑA'),(2,'asdfasdf',' asdfasdf','sadfsd',12345678,'Optometría',45664654,'asdfasd','dfgsdfg','Mujer','asdf'),(3,'Gregorio',' Casas','MIL',654,'Odontología',180055,'wfgtwert','retwerthd','Hombre','wilson'),(6,'COMODIN',' asdfasdf','ADOLFO',12345678,'Optometría',45664654,'dsfgdsfgs','dfgsdfg','Mujer','asdf'),(9,'Amador','Goonzales',' Goonzales',564978,'Optometría',4566465,'dfghgfhgf','dfghdfg','Mujer','asdff');
/*!40000 ALTER TABLE `medico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paciente` (
  `Paciente_id` int unsigned NOT NULL AUTO_INCREMENT,
  `Nombres` varchar(15) NOT NULL,
  `Apellido_Paterno` varchar(15) NOT NULL,
  `Apellido_Materno` varchar(15) NOT NULL,
  `Tipo_Paciente` enum('Estudiante','Profesor','Personal de apoyo') NOT NULL,
  `Edad` int NOT NULL,
  `Telefono` varchar(11) NOT NULL,
  `CURP` varchar(18) NOT NULL,
  `NNS` int NOT NULL,
  `Género` enum('Hombre','Mujer') NOT NULL,
  PRIMARY KEY (`Paciente_id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (22,'PEDRO','juanes','juanes','Estudiante',56,'5464987','asdfasdf',54987,'Hombre');
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receta`
--

DROP TABLE IF EXISTS `receta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `receta` (
  `Receta_id` int unsigned NOT NULL AUTO_INCREMENT,
  `Paciente_id` int DEFAULT NULL,
  `Nombre_pac` varchar(20) NOT NULL,
  `Apellido_pact` varchar(20) NOT NULL,
  `Apellido_pacm` varchar(20) NOT NULL,
  `Edad_pac` int NOT NULL,
  `Medico_id` int DEFAULT NULL,
  `Nombre_doc` varchar(20) NOT NULL,
  `Apellido_doct` varchar(20) NOT NULL,
  `Apellido_docm` varchar(20) NOT NULL,
  `Cedula_Profesional` int NOT NULL,
  `Especialidad` enum('Nutriología','Optometría','Odontología') NOT NULL,
  `Observaciones` varchar(100) NOT NULL,
  PRIMARY KEY (`Receta_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receta`
--

LOCK TABLES `receta` WRITE;
/*!40000 ALTER TABLE `receta` DISABLE KEYS */;
INSERT INTO `receta` VALUES (1,22,'PEDRO','juanes','juanes',56,1,'Luis','Gabriel','Roy',27635261,'Optometría','El paciente necesita comenzar a tomar más líquidos y Vcitamina C y D');
/*!40000 ALTER TABLE `receta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-08  5:20:34

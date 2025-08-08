/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

CREATE DATABASE IF NOT EXISTS `crud_cs` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `crud_cs`;

CREATE TABLE IF NOT EXISTS `aprendices` (
  `id` int NOT NULL AUTO_INCREMENT,
  `primer_nombre` varchar(50) NOT NULL,
  `segundo_nombre` varchar(50) DEFAULT NULL,
  `primer_apellido` varchar(50) NOT NULL,
  `segundo_apellido` varchar(50) DEFAULT NULL,
  `fecha_nacimiento` date NOT NULL,
  `tipo_documento_id` int NOT NULL,
  `numero_documento` varchar(10) NOT NULL,
  `grupo_sanguineo_id` int NOT NULL,
  `factor_sanguineo_id` int NOT NULL,
  `genero_id` int NOT NULL,
  `programa_id` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `numero_documento` (`numero_documento`),
  KEY `FK_personas_tema_parametro` (`tipo_documento_id`),
  KEY `FK_personas_tema_parametro_2` (`grupo_sanguineo_id`),
  KEY `FK_personas_tema_parametro_3` (`factor_sanguineo_id`),
  KEY `FK_personas_tema_parametro_4` (`genero_id`),
  KEY `FK_personas_tema_parametro_5` (`programa_id`),
  CONSTRAINT `FK_personas_tema_parametro` FOREIGN KEY (`tipo_documento_id`) REFERENCES `tema_parametro` (`id`),
  CONSTRAINT `FK_personas_tema_parametro_2` FOREIGN KEY (`grupo_sanguineo_id`) REFERENCES `tema_parametro` (`id`),
  CONSTRAINT `FK_personas_tema_parametro_3` FOREIGN KEY (`factor_sanguineo_id`) REFERENCES `tema_parametro` (`id`),
  CONSTRAINT `FK_personas_tema_parametro_4` FOREIGN KEY (`genero_id`) REFERENCES `tema_parametro` (`id`),
  CONSTRAINT `FK_personas_tema_parametro_5` FOREIGN KEY (`programa_id`) REFERENCES `tema_parametro` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `aprendices` (`id`, `primer_nombre`, `segundo_nombre`, `primer_apellido`, `segundo_apellido`, `fecha_nacimiento`, `tipo_documento_id`, `numero_documento`, `grupo_sanguineo_id`, `factor_sanguineo_id`, `genero_id`, `programa_id`) VALUES
	(2, 'h', 'h', 'h', 'h', '2025-08-08', 2, '453', 1, 1, 1, 1),
	(3, 'nicolas', 'antonio', 'arrieta', 'lagos', '2004-10-29', 1, '1099735735', 1, 1, 1, 1);

CREATE TABLE IF NOT EXISTS `parametro` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `parametro` (`id`, `nombre`) VALUES
	(1, 'CÉDULA DE CIUDADANÍA'),
	(2, 'TARJETA DE IDENTIDAD'),
	(3, 'CÉDULA DE EXTRANJERÍA'),
	(4, 'PASAPORTE'),
	(5, 'MASCULINO'),
	(6, 'FEMENINO'),
	(7, 'OTRO'),
	(8, 'A'),
	(9, 'B'),
	(10, 'AB'),
	(11, 'O'),
	(12, '+'),
	(13, '-'),
	(14, 'ADSO'),
	(15, 'SST');

CREATE TABLE IF NOT EXISTS `temas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `temas` (`id`, `nombre`) VALUES
	(1, 'TIPO_DOCUMENTO'),
	(2, 'GENERO'),
	(3, 'GRUPO_SANGUINEO'),
	(4, 'FACTOR_SANGUINEO'),
	(5, 'PROGRAMA_FORMACION');

CREATE TABLE IF NOT EXISTS `tema_parametro` (
  `id` int NOT NULL AUTO_INCREMENT,
  `tema_id` int NOT NULL,
  `parametro_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_tema_parametro_temas` (`tema_id`),
  KEY `FK_tema_parametro_parametro` (`parametro_id`),
  CONSTRAINT `FK_tema_parametro_parametro` FOREIGN KEY (`parametro_id`) REFERENCES `parametro` (`id`),
  CONSTRAINT `FK_tema_parametro_temas` FOREIGN KEY (`tema_id`) REFERENCES `temas` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `tema_parametro` (`id`, `tema_id`, `parametro_id`) VALUES
	(1, 1, 1),
	(2, 3, 8),
	(3, 2, 5),
	(4, 4, 12),
	(5, 5, 14),
	(6, 1, 2),
	(7, 1, 3),
	(8, 1, 4),
	(9, 4, 13),
	(10, 2, 6),
	(11, 2, 7),
	(12, 3, 9),
	(13, 3, 11),
	(14, 3, 10),
	(15, 5, 15);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

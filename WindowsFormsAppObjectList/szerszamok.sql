-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Nov 28. 18:18
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.1.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `szerszamok`
--
CREATE DATABASE IF NOT EXISTS `szerszamok` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `szerszamok`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szarszamok`
--

CREATE TABLE `szarszamok` (
  `szerszamId` int(11) DEFAULT NULL,
  `megnevezes` varchar(100) DEFAULT NULL,
  `egysegar` int(11) DEFAULT NULL,
  `darabszam` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `szarszamok`
--

INSERT INTO `szarszamok` (`szerszamId`, `megnevezes`, `egysegar`, `darabszam`) VALUES
(1, 'kalapács', 1500, 34),
(2, 'vésõ', 1000, 23),
(3, 'fûrész', 8300, 7),
(4, 'lemezolló', 500, 5);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

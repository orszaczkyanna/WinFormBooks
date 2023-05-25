-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Máj 25. 03:25
-- Kiszolgáló verziója: 10.4.27-MariaDB
-- PHP verzió: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `books`
--
CREATE DATABASE IF NOT EXISTS `books` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `books`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `book`
--

CREATE TABLE `book` (
  `bookid` int(10) UNSIGNED NOT NULL,
  `cim` varchar(255) NOT NULL,
  `szerzo` varchar(255) NOT NULL,
  `kep` varchar(255) NOT NULL,
  `tipus` varchar(255) NOT NULL,
  `olvasas` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `book`
--

INSERT INTO `book` (`bookid`, `cim`, `szerzo`, `kep`, `tipus`, `olvasas`) VALUES
(2, 'Az eltemetett óriás', 'Kazuo Ishiguro', 'kazuo_ishiguro__az_eltetemetett_orias.jpg', 'nyomtatott', 'nem'),
(3, 'Az eltemetett óriás', 'Kazuo Ishiguro', 'kazuo_ishiguro__napok_romjai.jpg', 'nyomtatott', 'igen'),
(4, '1q84 - első kötet', 'Murakami Haruki', 'murakami_haruki_1q84_1.jpg', 'nyomtatott', 'nem'),
(5, '1q84 - második kötet', 'Murakami Haruki', 'murakami_haruki_1q84_2.JPG', 'nyomtatott', 'nem'),
(6, '1q84 - harmadik kötet', 'Murakami Haruki', 'murakami_haruki_1q84_3.jpg', 'nyomtatott', 'nem'),
(7, 'Édes a bosszú részvénytársaság', 'Jonas Jonasson', 'jonas_jonasson_edes_a_bosszu_reszvenytarsasag.jpg', 'nyomtatott', 'igen'),
(8, 'Az analfabéta aki tudott számolni', 'Jonas Jonasson', 'jonas_jonasson_az_analfabeta_aki_tudott_szamolni.jpg', 'nyomtatott', 'igen'),
(9, 'A százéves ember, aki kimászott az ablakon és eltűnt', 'Jonas Jonassonnn', 'jonas_jonasson_a_szazeves_ember_aki_kimaszott_az_ablakon_es_eltunt.jpg', 'nyomtatott', 'igen'),
(10, 'A Szilmarilok', 'J. R. R. Tolkien', 'j_r_r_tolkien_a_szilmarilok.jpg', 'nyomtatott', 'nem'),
(11, 'Tűz és vér', 'Goerge R. R. Martin', 'george_r_r_martin_tuz_es_ver.webp', 'nyomtatott', 'nem'),
(12, 'Az utazó macska krónikája', 'Hiro Arikawa', 'hiro_arikawa_az_utazo_macska_kronikaja.jpg', 'ebook', 'nem'),
(13, 'Az eltemetett óriás', 'Kazuo Ishiguro', 'kazuo_ishiguro__az_eltetemetett_orias.jpg', 'ebook', 'nem'),
(14, 'Kékszakáll', 'Kurt Vonnegut', 'kurt_vonnegut_kekszakall.jpg', 'nyomtatott', 'igen'),
(19, 'Az ember tragédiája', 'Madách Imre', 'Cujo_(book_cover).jpg', 'nyomtatott', 'igen');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rent`
--

CREATE TABLE `rent` (
  `rentid` int(10) UNSIGNED NOT NULL,
  `userid` int(10) UNSIGNED DEFAULT NULL,
  `bookid` int(10) UNSIGNED DEFAULT NULL,
  `rentdate` timestamp NULL DEFAULT NULL,
  `pendingdate` timestamp NULL DEFAULT NULL,
  `returndate` timestamp NULL DEFAULT NULL,
  `rent` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `rent`
--

INSERT INTO `rent` (`rentid`, `userid`, `bookid`, `rentdate`, `pendingdate`, `returndate`, `rent`) VALUES
(1, 2, 11, '2023-03-26 22:05:39', NULL, NULL, 1),
(2, 2, 12, '2023-03-26 22:05:42', NULL, NULL, 1),
(3, 3, 5, '2023-03-26 22:05:45', '2023-03-26 22:09:50', '2023-03-26 22:09:56', 0),
(4, 3, 6, '2023-03-26 22:05:47', NULL, NULL, 1),
(5, 3, 4, '2023-03-26 22:05:50', NULL, NULL, 1),
(6, 2, 10, '2023-04-11 19:02:01', NULL, NULL, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `userid` int(10) UNSIGNED NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`userid`, `username`, `password`, `role`) VALUES
(2, 'user', '$2b$10$EqBFafMND5htEYXdFwYspuku1qUsnrhP5Pa21vNC7VTLeZqUNbLBe', 'user'),
(3, 'test', '$2b$10$ncAzjHAWG18FmcOeN.DYmebtFr57OlwNGiAaGReY/y3e/nuZEnZGa', 'user'),
(4, 'JohnDoe', '$2b$10$NS.03zHm/nbiRyEYxxes/u.5YQUtB8Zu8eoBZyq1EGAOyCYahHT.S', 'admin'),
(6, 'JaneDoe', '$2b$10$r543hoEuKkEWCWmno4YVQOQLs844fAI8FUjVHfZRVsSHTIfYXGHE2', 'admin'),
(7, 'masikAdmin', '$2b$10$B/1mqHxrbiWsdojI9rOR6uT3WPZS5BII/1nEm9raL58f7OsokIshy', 'admin'),
(8, 'felhasznalo', '$2b$10$3akX0w9NKB0Ah6cC4KKNKetqO6lr9gubGM2RxAVfJEbngbTE6WfN.', 'user'),
(9, 'VargaCsongor', '$2b$10$waZDyns9Q0fPxY8sYvXiv.AnSx0dwwbKX4EuwZQuMe4UjWf2oUiYi', 'user'),
(10, 'KissCsilla', '$2b$10$GE50xqagLMfNrMhaXSA18.RdYNA1fcvDQfDjOXmLR/SqXZ8Q8hPm2', 'user'),
(14, 'NagyCsaba', '$2b$10$40r8GScTMFZtYs4dNCYWnOYe33nnDWgi88buPAarOirxQZqVBh/BO', 'user'),
(15, 'JessicaDoe', '$2b$10$o/6gLr0Kj7l9q5JS/ZLcDe7uQwg.pLLn7Prrj1QDnGf86Pntx5hza', 'user'),
(16, 'JamesDoe', '$2b$10$BLSHQ1wB/.DsHBooCtfUcO41Uw2RZR0XPNZC7DmXKGQkkG0AD7D26', 'user'),
(17, 'EmilyProctor', '$2b$10$FcwS3yxgBAj8LLRg2jfFjeI29PFHzV2nmkpUpKg964KBL3znnzOoS', 'user'),
(18, 'SallieFletcher', '$2b$10$GCQV2N8C.50iLKnBxvfmvOwUwrL9q78bXUrQGO2q6xpo1uD/JM57.', 'admin'),
(23, 'mindegy', '$2a$10$WT0QnmWmWjxswoOD/oPrjeuVbzCzqI6rqQEnPtboO9eWP0wSTM5Ae', 'admin'),
(24, 'FelhasznaloNeve', '$2a$10$WT0QnmWmWjxswoOD/oPrjeuVbzCzqI6rqQEnPtboO9eWP0wSTM5Ae', 'admin');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`bookid`);

--
-- A tábla indexei `rent`
--
ALTER TABLE `rent`
  ADD PRIMARY KEY (`rentid`),
  ADD KEY `fk_rent_book` (`bookid`),
  ADD KEY `fk_rent_users` (`userid`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `book`
--
ALTER TABLE `book`
  MODIFY `bookid` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT a táblához `rent`
--
ALTER TABLE `rent`
  MODIFY `rentid` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `userid` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `rent`
--
ALTER TABLE `rent`
  ADD CONSTRAINT `fk_rent_book` FOREIGN KEY (`bookid`) REFERENCES `book` (`bookid`),
  ADD CONSTRAINT `fk_rent_users` FOREIGN KEY (`userid`) REFERENCES `users` (`userid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

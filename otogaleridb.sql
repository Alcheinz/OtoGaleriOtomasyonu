-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 15 May 2024, 16:23:03
-- Sunucu sürümü: 10.4.28-MariaDB
-- PHP Sürümü: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `otogaleridb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `araclar`
--

CREATE TABLE `araclar` (
  `id` int(11) NOT NULL,
  `plaka` varchar(15) NOT NULL,
  `marka` varchar(50) NOT NULL,
  `model` varchar(50) NOT NULL,
  `yakit_tipi` varchar(50) NOT NULL,
  `tramer_kaydi` varchar(50) NOT NULL,
  `km` int(50) NOT NULL,
  `fiyat` int(50) NOT NULL,
  `resimyolu` varchar(100) DEFAULT NULL,
  `durum` varchar(22) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `araclar`
--

INSERT INTO `araclar` (`id`, `plaka`, `marka`, `model`, `yakit_tipi`, `tramer_kaydi`, `km`, `fiyat`, `resimyolu`, `durum`) VALUES
(18, '33 CS 251', 'Renault', 'Megane', 'Benzin', 'Yok', 70000, 600000, 'images\\\\Megane.jpg', ''),
(19, '34 SN 726', 'BMW', '3Serisi', 'Benzin', 'Var', 85000, 1250000, 'images\\\\3Serisi.jpg', ''),
(20, '02 YLD 02', 'Audi', 'A3', 'Dizel', 'Yok', 55000, 950000, 'images\\\\A3.jpg', ''),
(21, '06 AOV 18', 'Fiat', 'Egea', 'Dizel', 'Yok', 60000, 550000, 'images\\\\Egea.jpg', ''),
(23, '02 ABS 86', 'Opel', 'Astra', 'Benzin', 'Yok', 65000, 700000, 'images\\\\Astra.jpg', ''),
(24, '02 OKT 02', 'Honda', 'Civic', 'Benzin', 'Var', 600000, 550000, 'images\\\\Civic.jpg', ''),
(25, '55 FR 38', 'Seat', 'Leon', 'Benzin', 'Var', 60000, 695000, 'images\\\\Leon.jpg', 'OnayBekliyor'),
(38, '02 ABS 86', 'Hyundai', 'İx35', 'Benzin + LPG', 'Yok', 120000, 850000, NULL, ''),
(39, '02 ABS 86', 'Hyundai', 'İx35', 'Benzin + LPG', 'Yok', 120000, 850000, NULL, 'OnayBekliyor'),
(46, '333333', 'Renault', 'Megane', 'Benzin', 'Yok', 70000, 600000, NULL, 'OnayBekliyor'),
(47, '444444', 'Renault', 'Megane', 'Benzin', 'Yok', 70000, 600000, NULL, 'OnayBekliyor');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `satis_onay`
--

CREATE TABLE `satis_onay` (
  `AracId` int(22) NOT NULL,
  `OnayID` int(22) NOT NULL,
  `KullaniciID` int(22) NOT NULL,
  `OnayDurumu` varchar(22) NOT NULL,
  `AdSoyad` varchar(22) NOT NULL,
  `TelNo` varchar(22) NOT NULL,
  `Adres` varchar(22) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `satis_onay`
--

INSERT INTO `satis_onay` (`AracId`, `OnayID`, `KullaniciID`, `OnayDurumu`, `AdSoyad`, `TelNo`, `Adres`) VALUES
(12, 0, 1, 'Beklemede', '', '', ''),
(11, 0, 1, 'Beklemede', 'oktay yoldaş', '541351', 'fsalkdgfvh sdghjkls ks');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `uyeler`
--

CREATE TABLE `uyeler` (
  `id` int(11) NOT NULL,
  `kullanici_adi` varchar(40) NOT NULL,
  `sifre` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `uyeler`
--

INSERT INTO `uyeler` (`id`, `kullanici_adi`, `sifre`) VALUES
(1, '', ''),
(11, 'furkan', 'şifre'),
(12, 'dd', 'dd'),
(13, 'ddd', 'ddd');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `araclar`
--
ALTER TABLE `araclar`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `uyeler`
--
ALTER TABLE `uyeler`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `araclar`
--
ALTER TABLE `araclar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- Tablo için AUTO_INCREMENT değeri `uyeler`
--
ALTER TABLE `uyeler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

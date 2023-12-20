-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 04, 2023 at 07:15 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.1.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rekammedis`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_dokter`
--

CREATE TABLE `tb_dokter` (
  `id_dokter` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jk` varchar(50) NOT NULL,
  `spesialis` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_dokter`
--

INSERT INTO `tb_dokter` (`id_dokter`, `nama`, `jk`, `spesialis`, `username`, `password`) VALUES
(1, 'Dr. Haidar', 'Laki-laki', 'Umum', 'GA001', '001'),
(2, 'Dr. Zidan', 'Laki-laki', 'Umum', 'GA002', '002'),
(4, 'Dr. Diah', 'Perempuan', 'Anak', 'GA003', '003');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pasien`
--

CREATE TABLE `tb_pasien` (
  `id_pasien` int(11) NOT NULL,
  `no_kartu` varchar(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `tgl` date NOT NULL,
  `umur` varchar(100) NOT NULL,
  `jk` varchar(100) NOT NULL,
  `no_hp` varchar(100) NOT NULL,
  `alamat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_pasien`
--

INSERT INTO `tb_pasien` (`id_pasien`, `no_kartu`, `nama`, `tgl`, `umur`, `jk`, `no_hp`, `alamat`) VALUES
(1, 'GAF001', 'KOIJA', '2000-09-16', '23', 'Laki-laki', '085156403514', 'SURABAYA'),
(2, 'GAF002', 'HANI', '2000-07-13', '23', 'Perempuan', '081767287161', 'PONDOK PESANTREN TEMBORO'),
(3, 'GAF003', 'ZAIDAN', '1999-12-01', '24', 'Laki-laki', '082198726716', 'JAKARTA'),
(5, 'GAF004', 'SANI', '2022-07-04', '2', 'Perempuan', '08726171271', 'SOLO');

-- --------------------------------------------------------

--
-- Table structure for table `tb_rekam_medis`
--

CREATE TABLE `tb_rekam_medis` (
  `id_rekam` int(11) NOT NULL,
  `id_pasien` int(11) NOT NULL,
  `keluhan` varchar(100) NOT NULL,
  `diagnosa` varchar(100) NOT NULL,
  `tindakan` varchar(100) NOT NULL,
  `tanggal` date NOT NULL,
  `id_dokter` int(11) NOT NULL,
  `status` enum('pemeriksaan','selesai') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_rekam_medis`
--

INSERT INTO `tb_rekam_medis` (`id_rekam`, `id_pasien`, `keluhan`, `diagnosa`, `tindakan`, `tanggal`, `id_dokter`, `status`) VALUES
(1, 1, 'GATAL', 'ALERGI', 'PERIKSA', '2023-09-02', 1, 'selesai'),
(2, 1, 'GATAL', 'ALERGI', 'KONTROL', '2023-09-02', 1, 'selesai'),
(3, 1, 'GATAL', 'ALERGI', 'KONTROL', '2023-09-02', 1, ''),
(4, 2, 'GATAL', 'GATAL', 'GATAL', '2023-09-02', 1, 'selesai'),
(5, 1, 'GATAL, DEMAM', 'ALERGI', 'PERIKSA', '2023-09-02', 1, 'selesai'),
(6, 1, '', '', '', '2023-09-02', 1, 'selesai'),
(7, 2, '', '', '', '2023-09-02', 1, 'pemeriksaan'),
(8, 3, 'SAKIT KEPALA', 'KELELAHAN', 'SUNTIK', '2023-09-04', 2, 'selesai'),
(9, 3, 'PUSING', 'KELELAHAN', 'TERAPI', '2023-09-04', 1, 'selesai'),
(10, 5, 'DEMAM', 'DEMAM', 'PERIKSA', '2023-09-04', 4, 'selesai');

-- --------------------------------------------------------

--
-- Table structure for table `tb_resep`
--

CREATE TABLE `tb_resep` (
  `id_resep` int(11) NOT NULL,
  `id_rekam` int(11) NOT NULL,
  `obat` text NOT NULL,
  `keterangan` text NOT NULL,
  `nama` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_resep`
--

INSERT INTO `tb_resep` (`id_resep`, `id_rekam`, `obat`, `keterangan`, `nama`) VALUES
(1, 1, 'KRIM HDC', '', ''),
(2, 2, 'KRIM HDC', '', ''),
(3, 3, 'KRIM HDC', '', ''),
(4, 4, 'GATAL', '', ''),
(5, 5, 'KRIM HDC, PARACETAMOL', '', ''),
(6, 8, 'PARACETAMOL', '', ''),
(7, 9, 'PANADOL', '', ''),
(8, 10, 'PARACETAMOL', '', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_dokter`
--
ALTER TABLE `tb_dokter`
  ADD PRIMARY KEY (`id_dokter`);

--
-- Indexes for table `tb_pasien`
--
ALTER TABLE `tb_pasien`
  ADD PRIMARY KEY (`id_pasien`);

--
-- Indexes for table `tb_rekam_medis`
--
ALTER TABLE `tb_rekam_medis`
  ADD PRIMARY KEY (`id_rekam`);

--
-- Indexes for table `tb_resep`
--
ALTER TABLE `tb_resep`
  ADD PRIMARY KEY (`id_resep`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_dokter`
--
ALTER TABLE `tb_dokter`
  MODIFY `id_dokter` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tb_pasien`
--
ALTER TABLE `tb_pasien`
  MODIFY `id_pasien` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tb_rekam_medis`
--
ALTER TABLE `tb_rekam_medis`
  MODIFY `id_rekam` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tb_resep`
--
ALTER TABLE `tb_resep`
  MODIFY `id_resep` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

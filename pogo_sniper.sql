/*
 Navicat Premium Data Transfer

 Source Server         : PlaySharp
 Source Server Type    : MySQL
 Source Server Version : 50639
 Source Host           : pokemonraro.com:3306
 Source Schema         : pogo_sniper

 Target Server Type    : MySQL
 Target Server Version : 50639
 File Encoding         : 65001

 Date: 31/05/2018 06:46:15
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for discordTokens
-- ----------------------------
DROP TABLE IF EXISTS `discordTokens`;
CREATE TABLE `discordTokens`  (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `token` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `bot` tinyint(1) NULL DEFAULT NULL,
  `e-mail` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `blocked` tinyint(1) UNSIGNED NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 13 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for hashProvider
-- ----------------------------
DROP TABLE IF EXISTS `hashProvider`;
CREATE TABLE `hashProvider`  (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `hashString` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `rpm` int(11) NULL DEFAULT NULL,
  `totalRPM` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 2 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for message
-- ----------------------------
DROP TABLE IF EXISTS `message`;
CREATE TABLE `message`  (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `message` longtext CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 2 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for pokedexKey
-- ----------------------------
DROP TABLE IF EXISTS `pokedexKey`;
CREATE TABLE `pokedexKey`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `key` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `isInvalid` tinyint(3) UNSIGNED ZEROFILL NULL DEFAULT 000,
  `requestCout` mediumint(8) UNSIGNED ZEROFILL NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 3 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for pokemonsCaptured
-- ----------------------------
DROP TABLE IF EXISTS `pokemonsCaptured`;
CREATE TABLE `pokemonsCaptured`  (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `userId` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PNumber` int(10) UNSIGNED NOT NULL,
  `PName` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PInformation` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PLatitude` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PLongitude` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `PTimeCatch` datetime(0) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 506 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for updates
-- ----------------------------
DROP TABLE IF EXISTS `updates`;
CREATE TABLE `updates`  (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `message` longtext CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL,
  `lastOne` int(11) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 2 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `numeroPedido` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `codigoCompra` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `totalPokemon` int(50) UNSIGNED NOT NULL,
  `maxPokemon` int(50) UNSIGNED NOT NULL,
  `iv100` int(1) NOT NULL,
  `active` int(1) NOT NULL,
  `totalPokemonFlee` int(10) UNSIGNED NOT NULL,
  `freeUser` tinyint(3) UNSIGNED NOT NULL,
  `hwid` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 230 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for version
-- ----------------------------
DROP TABLE IF EXISTS `version`;
CREATE TABLE `version`  (
  `status` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `toolVersion` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`toolVersion`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

SET FOREIGN_KEY_CHECKS = 1;

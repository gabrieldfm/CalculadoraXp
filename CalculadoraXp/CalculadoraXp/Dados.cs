﻿using System;
using System.Collections.Generic;

namespace CalculadoraXp
{
    public class Dados
    {
        public Dictionary<int, long> DicLvl;
        public void SetaDdos()
        {
            var dadosLvl = new Dictionary<int, long>();
            
            dadosLvl.Add(1, 0);
            dadosLvl.Add(2, 98);
            dadosLvl.Add(3, 199);
            dadosLvl.Add(4, 388);
            dadosLvl.Add(5, 790);
            dadosLvl.Add(6, 1498);
            dadosLvl.Add(7, 2565);
            dadosLvl.Add(8, 4176);
            dadosLvl.Add(9, 6397);
            dadosLvl.Add(10, 9230);
            dadosLvl.Add(11, 12956);
            dadosLvl.Add(12, 17596);
            dadosLvl.Add(13, 23083);
            dadosLvl.Add(14, 29830);
            dadosLvl.Add(15, 37795);
            dadosLvl.Add(16, 46824);
            dadosLvl.Add(17, 57489);
            dadosLvl.Add(18, 69694);
            dadosLvl.Add(19, 83153);
            dadosLvl.Add(20, 96660);
            dadosLvl.Add(21, 115993);
            dadosLvl.Add(22, 134770);
            dadosLvl.Add(23, 156016);
            dadosLvl.Add(24, 179392);
            dadosLvl.Add(25, 204375);
            dadosLvl.Add(26, 232266);
            dadosLvl.Add(27, 262591);
            dadosLvl.Add(28, 294668);
            dadosLvl.Add(29, 330110);
            dadosLvl.Add(30, 368290);
            dadosLvl.Add(31, 408349);
            dadosLvl.Add(32, 452248);
            dadosLvl.Add(33, 499189);
            dadosLvl.Add(34, 548118);
            dadosLvl.Add(35, 601380);
            dadosLvl.Add(36, 657988);
            dadosLvl.Add(37, 716675);
            dadosLvl.Add(38, 780206);
            dadosLvl.Add(39, 847387);
            dadosLvl.Add(40, 916720);
            dadosLvl.Add(41, 991426);
            dadosLvl.Add(42, 1070086);
            dadosLvl.Add(43, 1150953);
            dadosLvl.Add(44, 1237740);
            dadosLvl.Add(45, 1328785);
            dadosLvl.Add(46, 1422074);
            dadosLvl.Add(47, 1521848);
            dadosLvl.Add(48, 1626184);
            dadosLvl.Add(49, 1732783);
            dadosLvl.Add(50, 1846450);
            dadosLvl.Add(51, 1964983);
            dadosLvl.Add(52, 1964983);
            dadosLvl.Add(53, 2214246);
            dadosLvl.Add(54, 2347882);
            dadosLvl.Add(55, 2483765);
            dadosLvl.Add(56, 2627936);
            dadosLvl.Add(57, 2777581);
            dadosLvl.Add(58, 2929438);
            dadosLvl.Add(59, 3090220);
            dadosLvl.Add(60, 3256780);
            dadosLvl.Add(61, 3425499);
            dadosLvl.Add(62, 3603798);
            dadosLvl.Add(63, 3788179);
            dadosLvl.Add(64, 3974648);
            dadosLvl.Add(65, 4171370);
            dadosLvl.Add(66, 4374478);
            dadosLvl.Add(67, 4579585);
            dadosLvl.Add(68, 4795636);
            dadosLvl.Add(69, 5018377);
            dadosLvl.Add(70, 5243010);
            dadosLvl.Add(71, 5479296);
            dadosLvl.Add(72, 5722576);
            dadosLvl.Add(73, 5967623);
            dadosLvl.Add(74, 6225050);
            dadosLvl.Add(75, 6489775);
            dadosLvl.Add(76, 6756124);
            dadosLvl.Add(77, 7035598);
            dadosLvl.Add(78, 7322674);
            dadosLvl.Add(79, 7611213);
            dadosLvl.Add(80, 7913640);
            dadosLvl.Add(81, 8223973);
            dadosLvl.Add(82, 8535590);
            dadosLvl.Add(83, 8861876);
            dadosLvl.Add(84, 9196372);
            dadosLvl.Add(85, 9531955);
            dadosLvl.Add(86, 9883006);
            dadosLvl.Add(87, 10242571);
            dadosLvl.Add(88, 10603008);
            dadosLvl.Add(89, 10979730);
            dadosLvl.Add(90, 11365270);
            dadosLvl.Add(91, 11751449);
            dadosLvl.Add(92, 12154748);
            dadosLvl.Add(93, 12567169);
            dadosLvl.Add(94, 12979978);
            dadosLvl.Add(95, 13410760);
            dadosLvl.Add(96, 13850968);
            dadosLvl.Add(97, 14291295);
            dadosLvl.Add(98, 14750466);
            dadosLvl.Add(99, 15219367);
            dadosLvl.Add(100, 15688100);
            dadosLvl.Add(101, 16176566);
            dadosLvl.Add(102, 16675066);
            dadosLvl.Add(103, 17173093);
            dadosLvl.Add(104, 17691760);
            dadosLvl.Add(105, 18229765);
            dadosLvl.Add(106, 18748974);
            dadosLvl.Add(107, 19298748);
            dadosLvl.Add(108, 19859164);
            dadosLvl.Add(109, 20418443);
            dadosLvl.Add(110, 21000230);
            dadosLvl.Add(111, 21592963);
            dadosLvl.Add(112, 22184200);
            dadosLvl.Add(113, 22798906);
            dadosLvl.Add(114, 23424862);
            dadosLvl.Add(115, 24048945);
            dadosLvl.Add(116, 24697476);
            dadosLvl.Add(117, 25357561);
            dadosLvl.Add(118, 26015378);
            dadosLvl.Add(119, 26698640);
            dadosLvl.Add(120, 27393760);
            dadosLvl.Add(121, 28086199);
            dadosLvl.Add(122, 28805098);
            dadosLvl.Add(123, 29536159);
            dadosLvl.Add(124, 30264108);
            dadosLvl.Add(125, 31019550);
            dadosLvl.Add(126, 31787458);
            dadosLvl.Add(127, 32551805);
            dadosLvl.Add(128, 33344696);
            dadosLvl.Add(129, 34150357);
            dadosLvl.Add(130, 34951990);
            dadosLvl.Add(131, 35783236);
            dadosLvl.Add(132, 36627556);
            dadosLvl.Add(133, 37467363);
            dadosLvl.Add(134, 38337870);
            dadosLvl.Add(135, 39221755);
            dadosLvl.Add(136, 40100624);
            dadosLvl.Add(137, 41011298);
            dadosLvl.Add(138, 41935654);
            dadosLvl.Add(139, 42854473);
            dadosLvl.Add(140, 43806220);
            dadosLvl.Add(141, 44471953);
            dadosLvl.Add(142, 45731610);
            dadosLvl.Add(143, 46725336);
            dadosLvl.Add(144, 47733352);
            dadosLvl.Add(145, 48734735);
            dadosLvl.Add(146, 49771346);
            dadosLvl.Add(147, 50822551);
            dadosLvl.Add(148, 51866548);
            dadosLvl.Add(149, 52946950);
            dadosLvl.Add(150, 54042250);
            dadosLvl.Add(151, 55129749);
            dadosLvl.Add(152, 56254848);
            dadosLvl.Add(153, 57395149);
            dadosLvl.Add(154, 58527038);
            dadosLvl.Add(155, 59697740);
            dadosLvl.Add(156, 60883948);
            dadosLvl.Add(157, 62061115);
            dadosLvl.Add(158, 63278326);
            dadosLvl.Add(159, 64511347);
            dadosLvl.Add(160, 65734680);
            dadosLvl.Add(161, 66999306);
            dadosLvl.Add(162, 68280046);
            dadosLvl.Add(163, 69550433);
            dadosLvl.Add(164, 70863380);
            dadosLvl.Add(165, 72192745);
            dadosLvl.Add(166, 73511074);
            dadosLvl.Add(167, 74873248);
            dadosLvl.Add(168, 76252144);
            dadosLvl.Add(169, 77619303);
            dadosLvl.Add(170, 79031610);
            dadosLvl.Add(171, 80460943);
            dadosLvl.Add(172, 81877820);
            dadosLvl.Add(173, 83341166);
            dadosLvl.Add(174, 84821842);
            dadosLvl.Add(175, 86289325);
            dadosLvl.Add(176, 87804616);
            dadosLvl.Add(177, 89337541);
            dadosLvl.Add(178, 90856518);
            dadosLvl.Add(179, 92424660);
            dadosLvl.Add(180, 94010740);
            dadosLvl.Add(181, 95582099);
            dadosLvl.Add(182, 97203998);
            dadosLvl.Add(183, 98844139);
            dadosLvl.Add(184, 100468768);
            dadosLvl.Add(185, 102145330);
            dadosLvl.Add(186, 103840438);
            dadosLvl.Add(187, 105519225);
            dadosLvl.Add(188, 107251356);
            dadosLvl.Add(189, 109002337);
            dadosLvl.Add(190, 110736170);
            dadosLvl.Add(191, 112524776);
            dadosLvl.Add(192, 114332536);
            dadosLvl.Add(193, 116122303);
            dadosLvl.Add(194, 117968290);
            dadosLvl.Add(195, 119833735);
            dadosLvl.Add(196, 121680324);
            dadosLvl.Add(197, 123584598);
            dadosLvl.Add(198, 125508634);
            dadosLvl.Add(199, 127412933);
            dadosLvl.Add(200, 129376400);
            dadosLvl.Add(201, 131359933);
            dadosLvl.Add(202, 133322830);
            dadosLvl.Add(203, 135346396);
            dadosLvl.Add(204, 137390332);
            dadosLvl.Add(205, 139412715);
            dadosLvl.Add(206, 141497286);
            dadosLvl.Add(207, 143602531);
            dadosLvl.Add(208, 145685288);
            dadosLvl.Add(209, 147831770);
            dadosLvl.Add(210, 149999230);
            dadosLvl.Add(211, 152143249);
            dadosLvl.Add(212, 154352548);
            dadosLvl.Add(213, 156583129);
            dadosLvl.Add(214, 158789298);
            dadosLvl.Add(215, 161062320);
            dadosLvl.Add(216, 163356928);
            dadosLvl.Add(217, 165626135);
            dadosLvl.Add(218, 167963786);
            dadosLvl.Add(219, 170323327);
            dadosLvl.Add(220, 172656460);
            dadosLvl.Add(221, 175059646);
            dadosLvl.Add(222, 177485026);
            dadosLvl.Add(223, 179882973);
            dadosLvl.Add(224, 182352600);
            dadosLvl.Add(225, 184844725);
            dadosLvl.Add(226, 187308374);
            dadosLvl.Add(227, 189845348);
            dadosLvl.Add(228, 192405124);
            dadosLvl.Add(229, 194935363);
            dadosLvl.Add(230, 197540590);
            dadosLvl.Add(231, 200168923);
            dadosLvl.Add(232, 202766640);
            dadosLvl.Add(233, 205441026);
            dadosLvl.Add(234, 208138822);
            dadosLvl.Add(235, 210804905);
            dadosLvl.Add(236, 213549356);
            dadosLvl.Add(237, 216317521);
            dadosLvl.Add(238, 219052858);
            dadosLvl.Add(239, 221868280);
            dadosLvl.Add(240, 224707720);
            dadosLvl.Add(241, 227531199);
            dadosLvl.Add(242, 230400498);
            dadosLvl.Add(243, 233312119);
            dadosLvl.Add(244, 236188628);
            dadosLvl.Add(245, 239148710);
            dadosLvl.Add(246, 242133418);
            dadosLvl.Add(247, 245081845);
            dadosLvl.Add(248, 248115616);
            dadosLvl.Add(249, 251174317);
            dadosLvl.Add(250, 254195550);
            dadosLvl.Add(251, 257303916);
            dadosLvl.Add(252, 260437516);
            dadosLvl.Add(253, 263532443);
            dadosLvl.Add(254, 266716310);
            dadosLvl.Add(255, 269925715);
            dadosLvl.Add(256, 273095224);
            dadosLvl.Add(257, 276355498);
            dadosLvl.Add(258, 279641614);
            dadosLvl.Add(259, 282886593);
            dadosLvl.Add(260, 286224180);
            dadosLvl.Add(261, 289587913);
            dadosLvl.Add(262, 292909250);
            dadosLvl.Add(263, 296325056);
            dadosLvl.Add(264, 299767312);
            dadosLvl.Add(265, 303165895);
            dadosLvl.Add(266, 306660826);
            dadosLvl.Add(267, 310182511);
            dadosLvl.Add(268, 313659228);
            dadosLvl.Add(269, 317234190);
            dadosLvl.Add(270, 320836210);
            dadosLvl.Add(271, 324391949);
            dadosLvl.Add(272, 328047848);
            dadosLvl.Add(273, 331731109);
            dadosLvl.Add(274, 335366758);
            dadosLvl.Add(275, 339104500);
            dadosLvl.Add(276, 342869908);
            dadosLvl.Add(277, 346586355);
            dadosLvl.Add(278, 350406846);
            dadosLvl.Add(279, 354255307);
            dadosLvl.Add(280, 358053440);
            dadosLvl.Add(281, 361957586);
            dadosLvl.Add(282, 365890006);
            dadosLvl.Add(283, 369770713);
            dadosLvl.Add(284, 373759420);
            dadosLvl.Add(285, 377776705);
            dadosLvl.Add(286, 381740874);
            dadosLvl.Add(287, 385815048);
            dadosLvl.Add(288, 389918104);
            dadosLvl.Add(289, 393966623);
            dadosLvl.Add(290, 398127170);
            dadosLvl.Add(291, 402316903);
            dadosLvl.Add(292, 406450660);
            dadosLvl.Add(293, 410698486);
            dadosLvl.Add(294, 414975802);
            dadosLvl.Add(295, 419195685);
            dadosLvl.Add(296, 423531696);
            dadosLvl.Add(297, 427897501);
            dadosLvl.Add(298, 432204398);
            dadosLvl.Add(299, 436629500);
            dadosLvl.Add(300, 441084700);
            dadosLvl.Add(301, 445479499);
            dadosLvl.Add(302, 449994598);
            dadosLvl.Add(303, 454540099);
            dadosLvl.Add(304, 459023688);
            dadosLvl.Add(305, 463629690);
            dadosLvl.Add(306, 468266398);
            dadosLvl.Add(307, 472839665);
            dadosLvl.Add(308, 477537476);
            dadosLvl.Add(309, 482266398);
            dadosLvl.Add(310, 486930130);
            dadosLvl.Add(311, 491720656);
            dadosLvl.Add(312, 496542496);
            dadosLvl.Add(313, 501297783);
            dadosLvl.Add(314, 506181930);
            dadosLvl.Add(315, 511097695);
            dadosLvl.Add(316, 515945324);
            dadosLvl.Add(317, 520923998);
            dadosLvl.Add(318, 525934594);
            dadosLvl.Add(319, 530875453);
            dadosLvl.Add(320, 535949560);
            dadosLvl.Add(321, 541055893);
            dadosLvl.Add(322, 546090870);
            dadosLvl.Add(323, 551261316);
            dadosLvl.Add(324, 556464292);
            dadosLvl.Add(325, 561594275);
            dadosLvl.Add(326, 566861966);
            dadosLvl.Add(327, 572162491);
            dadosLvl.Add(328, 577388368);
            dadosLvl.Add(329, 582754210);
            dadosLvl.Add(330, 588153190);
            dadosLvl.Add(331, 593475849);
            dadosLvl.Add(332, 598940748);
            dadosLvl.Add(333, 604439089);
            dadosLvl.Add(334, 609859418);
            dadosLvl.Add(335, 615424280);
            dadosLvl.Add(336, 621022888);
            dadosLvl.Add(337, 626541775);
            dadosLvl.Add(338, 632207506);
            dadosLvl.Add(339, 637907287);
            dadosLvl.Add(340, 643525620);
            dadosLvl.Add(341, 649293126);
            dadosLvl.Add(342, 655094986);
            dadosLvl.Add(343, 660813653);
            dadosLvl.Add(344, 666683840);
            dadosLvl.Add(345, 672588685);
            dadosLvl.Add(346, 678408574);
            dadosLvl.Add(347, 684382348);
            dadosLvl.Add(348, 690391084);
            dadosLvl.Add(349, 696313083);
            dadosLvl.Add(350, 702391350);
            dadosLvl.Add(351, 708594883);
            dadosLvl.Add(352, 714529880);
            dadosLvl.Add(353, 720713546);
            dadosLvl.Add(354, 726932782);
            dadosLvl.Add(355, 733061665);
            dadosLvl.Add(356, 739351636);
            dadosLvl.Add(357, 745677481);
            dadosLvl.Add(358, 751911138);
            dadosLvl.Add(359, 758308320);
            dadosLvl.Add(360, 764741680);
            dadosLvl.Add(361, 771080999);
            dadosLvl.Add(362, 777586298);
            dadosLvl.Add(363, 784128079);
            dadosLvl.Add(364, 790573948);
            dadosLvl.Add(365, 797188270);
            dadosLvl.Add(366, 803839378);
            dadosLvl.Add(367, 810392685);
            dadosLvl.Add(368, 817116936);
            dadosLvl.Add(369, 823878277);
            dadosLvl.Add(370, 830539910);
            dadosLvl.Add(371, 837374996);
            dadosLvl.Add(372, 844247476);
            dadosLvl.Add(373, 851018323);
            dadosLvl.Add(374, 857965150);
            dadosLvl.Add(375, 864949675);
            dadosLvl.Add(376, 871830624);
            dadosLvl.Add(377, 878890098);
            dadosLvl.Add(378, 885987574);
            dadosLvl.Add(379, 892979513);
            dadosLvl.Add(380, 900152540);
            dadosLvl.Add(381, 907363873);
            dadosLvl.Add(382, 914467690);
            dadosLvl.Add(383, 921755176);
            dadosLvl.Add(384, 929081272);
            dadosLvl.Add(385, 936297855);
            dadosLvl.Add(386, 943700706);
            dadosLvl.Add(387, 951142471);
            dadosLvl.Add(388, 958472708);
            dadosLvl.Add(389, 965991830);
            dadosLvl.Add(390, 973550170);
            dadosLvl.Add(391, 980994949);
            dadosLvl.Add(392, 988631248);
            dadosLvl.Add(393, 996307069);
            dadosLvl.Add(394, 1003867278);
            dadosLvl.Add(395, 1011621660);
            dadosLvl.Add(396, 1019415868);
            dadosLvl.Add(397, 1027092395);
            dadosLvl.Add(398, 1034965766);
            dadosLvl.Add(399, 1042879267);
            dadosLvl.Add(400, 1050673000);
            dadosLvl.Add(401, 1058666266);
            dadosLvl.Add(402, 1066699966);
            dadosLvl.Add(403, 1074611793);
            dadosLvl.Add(404, 1082725860);
            dadosLvl.Add(405, 1090880665);
            dadosLvl.Add(406, 1098911474);
            dadosLvl.Add(407, 1107147248);
            dadosLvl.Add(408, 1115424064);
            dadosLvl.Add(409, 1123574743);
            dadosLvl.Add(410, 1131933130);
            dadosLvl.Add(411, 1140332863);
            dadosLvl.Add(412, 1148604300);
            dadosLvl.Add(413, 1157086206);
            dadosLvl.Add(414, 1165609762);
            dadosLvl.Add(415, 1174002845);
            dadosLvl.Add(416, 1182609762);
            dadosLvl.Add(417, 1191257461);
            dadosLvl.Add(418, 1199773078);
            dadosLvl.Add(419, 1208504740);
            dadosLvl.Add(420, 1217278660);
            dadosLvl.Add(421, 1225917699);
            dadosLvl.Add(422, 1234775598);
            dadosLvl.Add(423, 1243676059);
            dadosLvl.Add(424, 1252439408);
            dadosLvl.Add(425, 1261424450);
            dadosLvl.Add(426, 1270452358);
            dadosLvl.Add(427, 1279340905);
            dadosLvl.Add(428, 1288453996);
            dadosLvl.Add(429, 1297610257);
            dadosLvl.Add(430, 1306624890);
            dadosLvl.Add(431, 1315866936);
            dadosLvl.Add(432, 1325152456);
            dadosLvl.Add(433, 1334294063);
            dadosLvl.Add(434, 1343665970);
            dadosLvl.Add(435, 1353081655);
            dadosLvl.Add(436, 1362351124);
            dadosLvl.Add(437, 1371853798);
            dadosLvl.Add(438, 1381400554);
            dadosLvl.Add(439, 1390798773);
            dadosLvl.Add(440, 1400433120);
            dadosLvl.Add(441, 1410111853);
            dadosLvl.Add(442, 1419639710);
            dadosLvl.Add(443, 1429406636);
            dadosLvl.Add(444, 1439218252);
            dadosLvl.Add(445, 1448876635);
            dadosLvl.Add(446, 1458777046);
            dadosLvl.Add(447, 1468722451);
            dadosLvl.Add(448, 1478512248);
            dadosLvl.Add(449, 1488547050);
            dadosLvl.Add(450, 1498627150);

            DicLvl = dadosLvl;
        }

    }
}
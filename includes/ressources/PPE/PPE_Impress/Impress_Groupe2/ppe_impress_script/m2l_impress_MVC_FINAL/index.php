<?php
session_start();
require_once("vues/v_entete.php");
require_once("includes/connect_bdd.php");
require_once("includes/gestion_bdd.php");

if(!isset($_REQUEST['uc']))
     $uc = 'identification';
else
	$uc = $_REQUEST['uc'];

switch($uc)
{
	case 'identification':
		{include("controleurs/c_identification.php");break;}
	case 'menu':
		{include("vues/v_menu.php");break;}
	case 'trace_ligue':
		{include("controleurs/c_ligue.php");break;}
	case 'trace_periph':
		{include("controleurs/c_peripherique.php");break;}
	case 'gerer_periph':
		{include("controleurs/c_gerer_peripherique.php");break;}
	case 'deconnexion':
		{include("controleurs/c_deconnexion.php");break;}
	case 'cout_impr':
		{include("controleurs/c_cout.php");break;}
	case 'trace_date':
		{include("controleurs/c_date.php");break;}
	case 'gerer_ligue':
		{include("controleurs/c_gerer_ligue.php");break;}
	case 'trace_util':
		{include("controleurs/c_utilisateur.php");break;}
	case 'gerer_util':
		{include("controleurs/c_gerer_utilisateur.php");break; }
}

include("vues/v_footer.php") ;

?>

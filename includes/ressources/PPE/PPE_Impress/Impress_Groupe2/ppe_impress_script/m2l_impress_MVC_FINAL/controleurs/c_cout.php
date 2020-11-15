<?php
include("vues/v_menu.php") ;
		
if(!isset($_REQUEST['action']))
     $action = 'choisir';
else
	$action = $_REQUEST['action'];
	if (isset($_POST['btPeriph'])) $action = 'cout/periph';
	elseif (isset($_POST['btLigue'])) $action = 'cout/ligue';
	elseif (isset($_POST['btDate'])) $action = 'cout/Periode';
	elseif (isset($_POST['submit'])) $action = 'cout/Periode2';


			


switch($action)
{
	case 'choisir':
	{
		include("vues/v_cout_choisir.php");
		break;
	}
	
	case 'cout/periph':
	{
		$lesperif = selectPeripheriquesETPRIX();
		include("vues/v_cout_periph.php");
		break;
	}
	case 'cout/ligue':
	{
		$lesligues = selectLiguesETPRIX();
		include("vues/v_cout_ligue.php");
		break;
	}
	case 'cout/Periode':
	{
		include("vues/v_cout_periode_selection.php");
		break;
	}
	case 'cout/Periode2':
	{
		$heuremin = $_POST['min'];
		$heuremax = $_POST['max'];
		$datemin = $_POST['datemin'];
		$datemax = $_POST['datemax'];
		$hdmin = $datemin." ".$heuremin;
		$hdmax = $datemax." ".$heuremax;

		$laLigne = periodeETprix($hdmin,$hdmax);
		include("vues/v_cout_periode_afficher.php");
		break;
	}
}


?>



<?php 
include("vues/v_menu.php") ;
include("includes/gestion_date_bdd.php");
		
if(!isset($_REQUEST['action']))
     $action = 'selectionner';
else
	$action = $_REQUEST['action'];

switch($action)
{
	case 'selectionner':
	{

		include("vues/v_date_saisir.php");
		break;
	}
	
	case 'afficher':
	{
		$date = $_POST["DATE"];
		$execLesTraces = selecteDateTrace($date);
		include("vues/v_date_afficher.php");
		break;
	}
}

 ?>
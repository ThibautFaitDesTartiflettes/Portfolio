<?php
include("vues/v_menu.php") ;
		
if(!isset($_REQUEST['action']))
     $action = 'saisir';
else
	$action = $_REQUEST['action'];


	
switch($action)
{
	case 'saisir':
	{
		$execLesPeripherique=selectPeripheriques() ;
		include("vues/v_peripherique_critere.php");
		break;
	}
	
	case 'afficher':
	{
		//récupération du n° de ligue choisi
		$prp_id=$_REQUEST['prp_id'] ;
		$lePeripherique= selectUnPeripherique($prp_id);
		$execLesTraces= selectPeripheriqueTrace($prp_id);
		include("vues/v_peripherique_afficher.php");
		break;
	}
}


?>



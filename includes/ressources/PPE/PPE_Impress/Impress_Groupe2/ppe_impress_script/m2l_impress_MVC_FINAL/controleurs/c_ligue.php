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
		$execLesLigues=selectLigues() ;
		include("vues/v_ligue_critere.php");
		break;
	}
	
	case 'afficher':
	{
		//récupération du n° de ligue choisi
		$lgu_id=$_REQUEST['lgu_id'] ;
		$laLigue= selectUneLigue($lgu_id);
		$execLesTraces= selectLigueTrace($lgu_id);
		include("vues/v_ligue_afficher.php");
		break;
	}
}


?>



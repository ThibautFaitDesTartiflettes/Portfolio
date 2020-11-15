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
		$execlesUtilisateurs=selectUtilisateur();
		include("vues/v_utilisateur_critere.php");
		break;
	}
	
	case 'afficher':
	{
		//r�cup�ration de Identifiant de l'utilisateur
		$tls_id=$_REQUEST['TLS_ID'] ;
        $utilisateur = selectUnUtilisateur($tls_id);
        $execLesTraces= selectUtilisateurTrace($tls_id);
        include("vues/v_utilisateur_afficher.php");
        break;
	}
}


?>

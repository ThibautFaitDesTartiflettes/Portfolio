<?php
if(!isset($_REQUEST['action']))
     $action = 'demander';
else
	$action = $_REQUEST['action'];
	
switch($action)
{
	case 'demander':
	{
		include("vues/v_identification.php");
		break;
	}
	
	case 'verifier':
	{
		//récupération des identifiants et mots de passe passés par la méthode POST 
		$loginSaisi=$_REQUEST['login'] ;
		$mdpSaisi=$_REQUEST['mdp'] ;
		$tls_id= verifierIdentification($loginSaisi,$mdpSaisi );
		if($tls_id == 0)
		{
			include("vues/v_identification_erreur.php");
		}
		else
		{
			$_SESSION['TLS_ID'] = $tls_id ;
			$_SESSION['TLS_DROIT'] = getDroit($tls_id) ;
			header("Location:index.php?uc=menu");
		}
		break;
	}
}


?>



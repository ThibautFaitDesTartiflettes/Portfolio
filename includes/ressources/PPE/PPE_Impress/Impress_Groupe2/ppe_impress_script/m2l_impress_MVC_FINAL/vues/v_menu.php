<?php
echo '
<!-- affichage du menu en fonction du droit d\'accès-->
<ul id="menu">
    <li id="vide"></li>' ;

switch ($_SESSION['TLS_DROIT'])
{
	case 1 : {
		//Administrateur réseau et db
		echo '
				<li id="menu_link_first"><a href="index.php?uc=trace_ligue">Traces/Ligue</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_periph">Traces/Périph.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_date">Traces/Date</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_util">Traces/Util.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=gerer_util">Gérer Util.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=gerer_periph">Gérer périph.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=gerer_ligue">Gérer ligue</a></li>				
				' ;
		break ;
	}
	
	case 2 : {
		//Chef comptable
		echo '
				<li id="menu_link_first"><a href="index.php?uc=trace_ligue">Traces/Ligue</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_periph">Traces/Périph.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_date">Traces/Date</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_util">Traces/Util.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=cout_impr">Cout impr.</a></li>				
				' ;
		break ;
	}
	
	case 3 : {
		//Chargé de gestion
		echo '
				<li id="menu_link_first"><a href="index.php?uc=trace_date">Traces/Date</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_util">Traces/Util.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=cout_impr">Cout impr.</a></li>				
				' ;
		break ;
	}

	case 4 : {
		//Secrétaire
		echo '
				<li id="menu_link_first"><a href="index.php?uc=gerer_util">Gérer Util.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=gerer_ligue">Gérer ligue</a></li>
				' ;
		break ;
	}
	
}

if (isset($_SESSION['TLS_ID']))
echo '<li class="menu_link"><a href="index.php?uc=deconnexion">Deconnexion</a></li>
' ;
?>
</ul>

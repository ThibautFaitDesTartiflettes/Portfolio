<?php
echo '
<!-- affichage du menu en fonction du droit d\'acc�s-->
<ul id="menu">
    <li id="vide"></li>' ;

switch ($_SESSION['TLS_DROIT'])
{
	case 1 : {
		//Administrateur r�seau et db
		echo '
				<li id="menu_link_first"><a href="index.php?uc=trace_ligue">Traces/Ligue</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_periph">Traces/P�riph.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_date">Traces/Date</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_util">Traces/Util.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=gerer_util">G�rer Util.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=gerer_periph">G�rer p�riph.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=gerer_ligue">G�rer ligue</a></li>				
				' ;
		break ;
	}
	
	case 2 : {
		//Chef comptable
		echo '
				<li id="menu_link_first"><a href="index.php?uc=trace_ligue">Traces/Ligue</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_periph">Traces/P�riph.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_date">Traces/Date</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_util">Traces/Util.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=cout_impr">Cout impr.</a></li>				
				' ;
		break ;
	}
	
	case 3 : {
		//Charg� de gestion
		echo '
				<li id="menu_link_first"><a href="index.php?uc=trace_date">Traces/Date</a></li>
				<li id="menu_link_first"><a href="index.php?uc=trace_util">Traces/Util.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=cout_impr">Cout impr.</a></li>				
				' ;
		break ;
	}

	case 4 : {
		//Secr�taire
		echo '
				<li id="menu_link_first"><a href="index.php?uc=gerer_util">G�rer Util.</a></li>
				<li id="menu_link_first"><a href="index.php?uc=gerer_ligue">G�rer ligue</a></li>
				' ;
		break ;
	}
	
}

if (isset($_SESSION['TLS_ID']))
echo '<li class="menu_link"><a href="index.php?uc=deconnexion">Deconnexion</a></li>
' ;
?>
</ul>

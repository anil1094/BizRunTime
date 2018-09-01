<?php
if( isset($_GET['x'] ) && !empty($_GET['x'] ))
	$x=json_deecode($_GET['x']);
	echo $x->color[1];
?>
$(document).ready(
function()
{
	$('img.menuClass').hover(
		function()
		{
			$('ul.the_menu').slideToggle('medium');
		}
	)
}
);
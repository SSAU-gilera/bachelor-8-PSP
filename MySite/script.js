window.onload = initAll;
var xhr = false;
var xPos, yPos;

function initAll() {
	var allLinks = document.getElementsByClassName("prew");

	for (var i=0; i< allLinks.length; i++) {
		allLinks[i].onmouseover = showPreview;
	}
}

function showPreview(evt) {
	if (evt) {
		var url = evt.target;
	}
	else {
		evt = window.event;
		var url = evt.srcElement;
	}
	xPos = evt.clientX;
	yPos = evt.pageY;
	
	if (window.XMLHttpRequest) {
		xhr = new XMLHttpRequest();
	}
	else {
		if (window.ActiveXObject) {
			try {
				xhr = new ActiveXObject("Microsoft.XMLHTTP");
			}
			catch (e) { }
		}
	}

	if (xhr) {
		xhr.onreadystatechange = showContents;
		xhr.open("GET", url, true);
		xhr.send(null);
	}
	else {
		alert("Ошибка при создании XMLHttp запроса");
	}
	return false;
}

function showContents() {
	if (xhr.readyState == 4) {
		if (xhr.status == 200) {
			var outMsg = xhr.responseText;
		}
		else {
			var outMsg = "Проблема запросом, статус " + xhr.status;
		}

		var prevWin = document.getElementById("previewWin");
		prevWin.innerHTML = outMsg;
		prevWin.style.top = parseInt(yPos) -150 + "px";
		prevWin.style.left = parseInt(xPos) +70 + "px";
		prevWin.style.visibility = "visible";
		prevWin.onmouseout = function() {
			document.getElementById("previewWin").style.visibility = "hidden";
		}
	}
}

// REF: https://p5js.org/reference/

let angleX = 0;
let angleY = 0;
let angleZ = 0;

let canvasSide = 500;

let boxSide = canvasSide / 8;
let frameCounter = 0.0;
let frameScale = 0.01;

// Only support one touch for now.

let lastTouch = null;

let marginWidth = 0;
let marginHeight = 75;

let shakenNotStirred = false;

function setup() {
	createCanvas(windowWidth - marginWidth, windowHeight - marginHeight, WEBGL);

	lastTouch = createVector(-1, -1);
}

function deviceShaken() {
	shakenNotStirred = !shakenNotStirred;
}

function draw() {
	background(128);

	// If no light is present, the color will be very flat

	ambientLight(60, 60, 60);
	pointLight(255, 255, 255, 0, -canvasSide / 4, canvasSide / 4);

	//normalMaterial();         // Typically used for debugging.

	// Rotate the reference
	// No mouse on mobile! (what if there is a stylus?)

	//if (mouseIsPressed) {
	//	if (mouseButton == LEFT) {
	//		angleX += -movedY * 0.01;
	//		angleY += movedX * 0.01;

	//		rotateX(angleX);
	//		rotateY(angleY);
	//	} else if (mouseButton == RIGHT) {
	//		angleX += -movedY * 0.01;
	//		angleZ += movedX * 0.01;

	//		rotateX(angleX);
	//		rotateZ(angleZ);
	//	}

	//	frameCounter = angleX / frameScale;
	//}
	//else

	if (touches.length > 0) {
		//console.log("touches");
		//console.log(touches[0]);

		if (lastTouch.x >= 0 && lastTouch.y >= 0) {
			angleX += -(touches[0].y - lastTouch.y) * 0.01;
			angleY += (touches[0].x - lastTouch.x) * 0.01;
		}

		rotateX(angleX);
		rotateY(angleY);

		lastTouch.x = touches[0].x;
		lastTouch.y = touches[0].y;
	}
	else if (shakenNotStirred) {
		frameCounter++;

		angleX = frameCounter * frameScale;
		angleY = angleX * 0.25;

		rotateX(angleX);
		rotateY(angleY);
	}

	//noStroke();      // Get ride of the edges

	box(boxSide);
}

function touchEnded() {
	console.log("touchEnded()");

	lastTouch.x = -1;
	lastTouch.y = -1;
}

function touchMoved() {
	console.log("touchMoved()");

	if (touches.length > 0) {
		lastTouch.x = touches[0].x;
		lastTouch.y = touches[0].y;
	}

	draw();
}

function touchStarted() {
	console.log("touchStarted()");

	shakenNotStirred = !shakenNotStirred;

	if (touches.length > 0) {
		lastTouch.x = touches[0].x;
		lastTouch.y = touches[0].y;
	}
}

function windowResized() {
	resizeCanvas(windowWidth - marginWidth, windowHeight - marginHeight);
}
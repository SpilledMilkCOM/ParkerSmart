// REF: https://p5js.org/reference/

let angleX = 0;
let angleY = 0;
let angleZ = 0;

let canvasSide = 500;

let boxSide = canvasSide / 8;

let frameScale = 0.01;

// Only support one touch for now.

let lastSwipe = null;
let lastTouch = null;

let marginWidth = 0;
let marginHeight = 75;

let shakenNotStirred = true;

function setup() {
	createCanvas(windowWidth - marginWidth, windowHeight - marginHeight, WEBGL);

	lastSwipe = createVector(0, 0);
	lastTouch = createVector(-1, -1);
}

function deviceShaken() {
	//shakenNotStirred = !shakenNotStirred;

	lastSwipe.x = 10;
	lastSwipe.y = 10;
}

function draw() {
	background(128);

	// If no light is present, the color will be very flat

	ambientLight(60, 60, 60);
	pointLight(255, 255, 255, 0, -canvasSide / 4, canvasSide / 4);

	//normalMaterial();         // Typically used for debugging.

	// Rotate the reference
	// No mouse on mobile! (what if there is a stylus?)
	// If "swiped" (touched) then rotate with a decaying angle.

	if (shakenNotStirred) {
		angleX += lastSwipe.y / 180 * PI;
		angleY += lastSwipe.x / 180 * PI;

		rotateX(angleX);
		rotateY(angleY);

		if (lastSwipe.x > 0) {

			if (lastSwipe.x < 0.01) {
				lastSwipe.x /= 2;
			} else {
				lastSwipe.x -= 0.01;
			}
		}
		else {

			if (lastSwipe.x > -0.01) {
				lastSwipe.x /= 2;
			} else {
				lastSwipe.x += 0.01;
			}
		}

		if (lastSwipe.y > 0) {
			if (lastSwipe.y < 0.01) {
				lastSwipe.y /= 2;
			} else {
				lastSwipe.y -= 0.01;
			}
		}
		else {

			if (lastSwipe.y > -0.01) {
				lastSwipe.y /= 2;
			} else {
				lastSwipe.y += 0.01;
			}
		}

		if (Math.abs(lastSwipe.x) < 0.0001) {
			lastSwipe.x = 0;
		}

		if (Math.abs(lastSwipe.y) < 0.0001) {
			lastSwipe.y = 0;
		}

		//if (lastSwipe.x == 0 && lastSwipe.y == 0) {
		//	shakenNotStirred = false;
		//}

		//console.log("lastSwipe: " + lastSwipe.x + ", " + lastSwipe.y);
	}

	//noStroke();      // Get ride of the edges

	box(boxSide);
}

function touchEnded() {
	//lastTouch.x = -1;
	//lastTouch.y = -1;
}

function touchMoved() {
	if (touches.length > 0) {

		// Establish initial rotational velocity.

		lastSwipe.x = touches[0].x - lastTouch.x;
		lastSwipe.y = touches[0].y - lastTouch.y;

		lastTouch.x = touches[0].x;
		lastTouch.y = touches[0].y;

		//console.log("lastSwipe: " + lastSwipe.x + ", " + lastSwipe.y);
	}
}

function touchStarted() {
	//shakenNotStirred = !shakenNotStirred;

	if (!shakenNotStirred) {
		lastSwipe.x = 0;
		lastSwipe.y = 0;
	}
	else if (touches.length > 0) {
		lastTouch.x = touches[0].x;
		lastTouch.y = touches[0].y;
	}
}

function windowResized() {
	resizeCanvas(windowWidth - marginWidth, windowHeight - marginHeight);
}
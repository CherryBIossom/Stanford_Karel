//Make Karel fill the world
//with beepers

function main() {
   while(leftIsClear()) {
		putBeeperLine();
		comeback();
		moveall();
	}
	putBeeperLine();
}
 
function putBeeperLine(){
	putBeeper();
	while(frontIsClear()) {
		move();
		putBeeper();
	}
}
 
function comeback(){
	turnAround();
	while(frontIsClear()) {
		move();
	}
}
 
function moveall(){
	turnRight();
	move();
	turnRight();
}
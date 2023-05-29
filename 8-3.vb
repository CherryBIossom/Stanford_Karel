//Karel tried to put a line
//of beepers but missed the
//first one. Help!
function main() {
   putBeeper();
   putBeeperLine();
}

function putBeeperLine(){
   while(frontIsClear()) {
      move();
      putBeeper();
   }
}

//위는 되는데 아래는 왜 안 되지?

//Karel tried to put a line
//of beepers but missed the
//first one. Help!
function main() {
   putBeeperLine();
}

function putBeeperLine(){
   while(frontIsClear()) {
      putBeeper();
      move();
   }
}
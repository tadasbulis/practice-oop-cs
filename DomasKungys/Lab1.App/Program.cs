
Random rnd = new  Random();

bool allowChallenge = args.Contains("--challenge");
int max = allowChallenge ? 5 : 4;
int task = rnd.Next(1, max + 1);

Console.Write(task);

if (task == 5) {
  int fallback = rnd.Next(1, 5); // 1..4
  // rodyti ir #5, ir fallback
};


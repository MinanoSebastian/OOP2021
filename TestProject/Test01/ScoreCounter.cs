using System.Collections.Generic;
using System.IO;

namespace Test01 {
   public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath); 
        }


        //メソッドの概要： 
         private static IEnumerable<Student> ReadScore(string filePath) {
            var score = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach(var line in lines) {
                var item = line.Split(',');
                var stu = new Student {
                    Name = item[0],
                    Subject = item[1],
                    Score = int.Parse(item[2])
                };
                score.Add(stu);
            }
            return score;

            
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(Student.Subject))
                    dict[Student.Subject] += Student.Score;
                else
                    dict[Student.Subject] = Student.Score;
            }
            return dict;
        }
    }
}

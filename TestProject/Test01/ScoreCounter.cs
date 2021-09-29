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
           
            var students= new List<Student>();
            var lines = File.ReadAllLines(filePath);
            
            foreach(var line in lines) {
                var items = line.Split(',');
                var student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(student);
            }
            return students;        
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject)){
                    dict[student.Subject] += student.Score;
                }else{
                    dict[student.Subject] = student.Score;
                }
            }
            return dict;
        }
    }
}

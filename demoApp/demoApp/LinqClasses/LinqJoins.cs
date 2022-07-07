using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoApp.model;

/*
 * Join
 * The Join operator joins two sequences (collections) based on a key and returns a resulted sequence.
 * 
 * 
 * GroupJoin	
 * The GroupJoin operator joins two sequences based on keys and returns groups of sequences. It is like Left Outer Join of SQL.
 * 
 * 
 * 
 * Join and GroupJoin are joining operators.
 * 
 * Join is like inner join of SQL. It returns a new collection that contains common elements from two collections whosh keys matches.
 * 
 * Join operates on two sequences inner sequence and outer sequence and produces a result sequence.
 * 
 * Join query syntax:
 
from... in outerSequence
join... in innerSequence 
on  outerKey equals innerKey
select ...
 * 
 * 
 * 
 * 
 */











namespace demoApp
{
    public class LinqJoins
    {

        public void Joins()
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1 },
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =2 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            IList<Standard> standardList = new List<Standard>() {
            new Standard(){ StandardID = 1, StandardName="Standard 1"},
            new Standard(){ StandardID = 2, StandardName="Standard 2"},
            new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };


            var joinresqs =(from std in studentList
                            join stand in standardList on std.StandardID equals stand.StandardID
                            select(std)).ToList();

            foreach (var join in joinresqs)
                Console.WriteLine(join.StudentName);


            var joinresms = studentList.Join(
                            standardList,
                            std => std.StudentID,
                            stand => stand.StandardID,
                            (std, stand) => new
                            {
                                StudentName = std.StudentName,
                                StandardName = stand.StandardName
                            }).ToList();

            var innerJoin = studentList.Join(// outer sequence 
                      standardList,  // inner sequence 
                      student => student.StandardID,    // outerKeySelector
                      standard => standard.StandardID,  // innerKeySelector
                      (student, standard) => new  // result selector
                      {
                          StudentName = student.StudentName,
                          StandardName = standard.StandardName
                      });


            //GroupJoin

            var groupJoin = standardList.GroupJoin(// outer sequence 
                                  studentList,  //inner sequence
                                std => std.StandardID, //outerKeySelector 
                                s => s.StandardID,     //innerKeySelector
                                (std, studentsGroup) => new // resultSelector 
                                {
                                    Students = studentsGroup,
                                    StandarFulldName = std.StandardName
                                });



            var joinbymems = studentList.Join(
                standardList,
                std => std.StandardID,
                stand => stand.StandardID,
                (std, stand) => new
                {
                    stdName = std.StudentName,
                    standdetais = stand
                });

            var grpJoinbyme = standardList.GroupJoin(
                studentList,
                std => std.StandardID,
                stand => stand.StandardID,
                (std, groupstand) => new
                {
                    studentName=std.StandardName,
                    stdGrp =groupstand
                });
            

            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.StandarFulldName);

                foreach (var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }
        }

    }
}

/*
select * from student
1- student table,
	insert:: insertStudent "Omar","Muhammad","Minya",24,1234,1234,1
	select:: selectStudent 1234 //by NID
			 selectAllStudents
	delete:: deleteStudent 1234 //by NID
	update:: updateStudentAddress 1234,'Minya'

2- INSTRUCTORS TABLE
	insert:: insertInstructor "Hassan","Fathi","Alex",35,1237,1237,1,1
	select:: selectInstructor 1234
		     selectAllInstructors
			 // can add viewStudntInstructors 1234
						viewStudntsInstructor 1234
	delete:: deleteInstructor 1234 //by NID
	update:: updateInstructorAddress 1234,'Minya'

3- STUDENT INSTRUCTOR TABLE
	insert:: insertStudentdInst 1234,1234
	select:: viewStudntsInstructors
		// can add viewStdInsts 1234
			   viewInstStd 1234
	delete:: deleteStdInstRelation 1234,1234
	update::updateStudentdInstructor 1,1,1

4-  DEPARTMENT TABLE
	insert:: insertDepartment "SD","System Developement Track"
	select:: selectDepartment "SD"
		     selectAllDepartments
	delete:: deleteDeparment "SD"
	update:: updateDepartmentDesc "SD","new desc"

5- INSTRUCTOR_COUSE TABLE
	insert:: insertInstructorCrs 1234,'C#'
	select:: viewInstructorsCoursec
		// can add viewInstCrs 1234
			   viewCrInsts 1234
	delete:: deleteInstCrsRelation
	update:: updateInstructorCrs 1234,'C#','C++'

6- STUDENT_COURSE TABLE
	insert:: insertStudentCrs 1234,'C#',80
	select::viewStudentsCoursesGrades
		// as above
	delete:: deleteStdCrsRelation 1234,"C#"
	update:: updateStudentCrs 1234,'C#','C++'


== REPORTS PART ==

-- getStudentsByDeptId 1

-- 	getStudentGrades 1

-- 

*/

--================= 1- STUDENT TABLE ======================

-- ========Insertion==========
create proc insertStudent 
(
	@fName varchar(20),
	@lName varchar(20),
	@address varchar(50),
	@age int,
	@password varchar(20),
	@nID int,
	@dept_id int
)
as
	begin try
		insert into Student
		values(@fName,@lName,@address,@age,@password,@nID,@dept_id)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

-- proc Execution 
	insertStudent "Omar","Muhammad","Minya",24,1234,1234,1


--=========SELECTION BY NID===============
create proc selectStudent @nID int
as
	begin try
		select St_id,StF_Name,StL_Name,St_Address,St_Age,St_Password,St_National_id,dept.Dept_name
		from Student as s,Department as dept
		where s.St_id=@nID
		and s.Dept_id=dept.Dept_id
 	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch


		

--=========Select ALL STUDENTS===============
create proc selectAllStudents
as
	begin try
	--select * from Student
	/*	
		select St_National_id as Nastional_ID,CONCAT(StF_Name,' ',StL_Name)as Student_name, St_Address as Adress,St_Age as Age,Dept_name as Department_name
		from Student as s, Department as dept
		where s.Dept_id=dept.Dept_id
	*/
	select s.*
		from Student as s, Department as dept
		where s.Dept_id=dept.Dept_id
 	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch




--===========DELETE============
create proc deleteStudent @nID int
as
	begin try
		delete from Student 
		where St_National_id=@nID
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

-- proc exec
	deleteStudent 1234


--========UPDATING==================
create proc updateStudentAddress @nId int,@adrs varchar(20)
as
	begin try
		update Student
		set St_Address=@adrs
		where St_National_id=@nId
	end try
	begin catch
			select 'QueryError, Nothing Has Executed'
	end catch
--=================2- INSTRUCTORS TABLE======================

-- ========Insertion==========
create proc insertInstructor
(
@fName varchar(20),
@lName varchar(20),
@address varchar(50),
@age int,
@password varchar(20),
@nID int,
@mngr_id int,
@dept_id int
)
as
	begin try
		insert into Instructor
		values(@fName,@lName,@address,@age,@password,@nID,@mngr_id,@dept_id)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--=========SELECTION BY NID===============
create proc selectInstructor @nID int
as
	begin try
		select Ins_id,InsF_Name,InsL_Name,Ins_Address,Ins_Age,Ins_National_id,Ins_Password,dept.Dept_name
		from Instructor as inst,Department as dept
		where Ins_id=@nID
		and inst.Dept_id=dept.Dept_id
 	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--=========Selction ALL===============
create proc selectAllInstructors
as
	begin try
		select Ins_id,InsF_Name,InsL_Name,Ins_Address,Ins_Age,Ins_National_id,Ins_Password,dept.Dept_name
		from Instructor as ins,Department as dept
		where ins.Dept_id=dept.Dept_id

 	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--===========DELETE============
create proc deleteInstructor @nID int
as
	begin try
		delete from Instructor 
		where Ins_National_id=@nID
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--========UPDATING==================
create proc updateInstructorAddress @nId int,@adrs varchar(20)
as
	begin try
		update Instructor
		set Ins_Address=@adrs
		where Ins_National_id=@nId
	end try
	begin catch
			select 'QueryError, Nothing Has Executed'
	end catch

--=================4-STUDENT INSTRUCTOR TABLE======================

-- ========Insertion==========

create proc insertStudentdInst
(
@std_nID int,
@inst_nID int
)
as
	begin try
		insert into Std_Ins
		select(select St_id from Student where St_National_id= @std_nID ),
		(select Ins_id from Instructor where Ins_National_id= @inst_nID)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch



--=========SELECTION ALL STUDENT and thei insts===============
create proc viewStudntsInstructors
as
	begin try
		select Concat(st.StF_Name,' ',st.StL_Name) as StudentName,Concat(ins.InsF_Name,' ',ins.InsL_Name) as InstructorName
		from Student as st,Instructor as ins,Std_Ins as stins
		where  st.St_id=stins.St_id and ins.Ins_id=stins.Ins_id --and st.St_National_id=@nID if need specifeic student or instructor
 	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

-- proc Execution 
		viewStudntsInstructors

--===========DELETE============
create proc deleteStdInstRelation @st_nID int,@ins_nID int
as
	begin try
		delete from Std_Ins 
		where St_id=(select St_id from Student where St_National_id=@st_nID)
		And
		Ins_id =(select Ins_id from Instructor where Ins_National_id=@ins_nID)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--========UPDATING STUDENT INSTRUCTOR==================
create proc updateStudentdInstructor @std_nID int ,@old_inst_nID int,@new_ins_nID int
as
	begin try
	update Std_Ins
	set Ins_id=(select Ins_id from Instructor where Ins_National_id=@new_ins_nID)
	where St_id=(select St_id from Student where St_National_id=@std_nID)
	and
	Ins_id=(select Ins_id from Instructor where Ins_National_id=@old_inst_nID)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--=================DEPARTMENT TABLE======================

--========Insertion==========
create proc insertDepartment
(
@dept_name varchar(20),
@dept_desc varchar(100)
)
as
	begin try
		insert into Department
		values(@dept_name,@dept_desc)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--=========SELECTION BY dept Name===============
create proc selectDepartment @dept_name varchar(20)
as
	begin try
		select * from Department where Dept_name=@dept_name
 	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

-- proc Execution 
		selectDepartment "SD"

--=========Selction ALL===============
create proc selectAllDepartments
as
	begin try
		select Dept_name as Department_Name,Dept_desc Department_Description from Department
 	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch
--===========DELETE============
create proc deleteDeparment @dept_name varchar(20)
as
	begin try
		delete from Department 
		where Dept_name=@dept_name
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--========UPDATING==================
create proc updateDepartmentDesc @name varchar(20),@desc varchar(20)
as 
	begin try
		update Department
		set Dept_desc=@desc
		where Dept_name=@name
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--================= INSTRUCTOR_COUSE TABLE ======================

-- ========Insertion==========

create proc insertInstructorCrs
(
@inst_nID int,
@crs_name varchar(20)
)
as
	begin try
		insert into Ins_Crs
		select(select Ins_id from Instructor where Ins_National_id= @inst_nID ),
		(select Crs_id from Courses where Crs_name= @crs_name)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch


--=========SELECTION ALL Course WITH INST NID===============
create proc viewInstructorsCoursec 
as
	begin try
		select Concat(ins.InsF_Name,' ',ins.InsL_Name) as Instructor_Name, cr.Crs_name  as Course_Name
		from Courses as cr,Instructor as ins,Ins_Crs as instcr
		where  cr.Crs_id=instcr.Crs_id and ins.Ins_id=instcr.Ins_id --and st.St_National_id=@nID if need specifeic student or instructor
 	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--===========DELETE============
create proc deleteInstCrsRelation  @inst_nID int,@crs varchar(20)
as
	begin try
		delete from Ins_Crs 
		where Ins_id=(select Ins_id from Instructor where Ins_National_id=@inst_nID)
		And
		Crs_id =(select Crs_id from Courses where Crs_name=@crs)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--========UPDATING  INSTRUCTOR Course==================
create proc updateInstructorCrs @inst_nID int,@oldCrs varchar(20),@newCrs varchar(20) 
as
	begin try
	update Ins_Crs
	set Crs_id=(select Crs_id from Courses where Crs_name=@newCrs)
	where Ins_id=(select Ins_id from Instructor where Ins_National_id=@inst_nID)
	and
	Crs_id=(select Crs_id from Courses where Crs_name=@oldCrs)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--================= STUDENT_COURSE TABLE ======================

-- ========Insertion==========

create proc insertStudentCrs
(
@std_nID int,
@crs_name varchar(20),
@grade int
)
as
	begin try
		insert into St_Crs
		select(select St_id from Student where St_National_id= @std_nID ),
		(select Crs_id from Courses where Crs_name= @crs_name),
		@grade
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--=========SELECTION ALL Course WITH STU NID===============
create proc viewStudentsCoursesGrades
as
	begin try
		select Concat(st.StF_Name,st.StL_Name)as Student_Name,cr.Crs_name as Course_Name,stcr.Crs_grade as Student_grade
		from Student as st,Courses as cr,St_Crs as stcr
		where st.St_id=stcr.St_id and cr.Crs_id=stcr.Crs_id
 	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

--===========DELETE============
create proc deleteStdCrsRelation @std_nID int,@crs varchar(20)
as
	begin try
		delete from St_Crs 
		where St_id=(select St_id from Student where St_National_id=@std_nID)
		And
		Crs_id =(select Crs_id from Courses where Crs_name=@crs)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

-- ============== UPDATE ==============

create proc updateStudentCrs @nid int,@oldCrs varchar(20),@newCrs varchar(20)
as
	begin try
		update Ins_Crs
		set Crs_id=(select Crs_id from Courses where Crs_name=@newCrs)
		where Ins_id=(select Ins_id from Instructor where Ins_National_id=@nid)
		and 
		Crs_id=(select Crs_id from Courses where Crs_name=@oldCrs)
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

----================================================ course Table======================================================
----------------------------------- insert command------------------------------------------
create proc insertCourse (@courseName varchar(20) , @courseDuration int)
as
  begin try
   insert into Courses
   Values(@courseName,@courseDuration)
  end try
  begin catch
		select 'QueryError, Nothing Has Executed'
  end catch
  Go

  ----------------------------------- select command------------------------------------------------

 --select command
 create proc selectCourse @courserID int
 as 
  begin try
    select * from Courses
	where Crs_id=@courserID
  end try
  begin catch
		select 'QueryError, Nothing Has Executed'
  end catch
----------------------------------- update command------------------------------------------------

 --update command
 create proc updateCourseName @courserID int,@courseName varchar(20)
 as 
 begin try
    update Courses
	set Crs_name=@courseName
	where Crs_id=@courserID
 end try
  begin catch
		select 'QueryError, Nothing Has Executed'
  end catch
 
 Go
 ----------------------------------- delete command------------------------------------------------

 --delete command
create proc deleteCourse @CrsID int
 as 
 begin try
    delete Courses
	where Crs_id=@CrsID
end try
 begin catch
		select 'QueryError, Nothing Has Executed'
  end catch
 Go
--================================================ Question Table======================================================
-----------------------------------insert command------------------------------------------------


  -- insertQuetions
create proc insetQuestions(@QuestionDiscription varchar(200),@QuetionType varchar(10),@grade int,@modelAnswer varchar(40),@courseId int)
 as
 begin try
  insert into Questions
  Values(@QuestionDiscription,@QuetionType,@grade,@modelAnswer,@courseId)
  end try
  begin catch
		select 'QueryError, Nothing Has Executed'
  end catch


  Go
  ----------------------------------- select command------------------------------------------------

-- select Quetion
create proc SelectQuetions @courseId int
as
begin try
select * from Questions
where Crs_id=@courseId
end try
 begin catch
		select 'QueryError, Nothing Has Executed'
  end catch

Go
  ----------------------------------- update command------------------------------------------------

-- update Quetion
create proc updateQuetions @questionGrade int,@id int
as
begin try
	update Questions 
	set Q_grade=@questionGrade
	where Q_id=@id
end try
begin catch
		select 'QueryError, Nothing Has Executed'
  end catch

Go
----------------------------------- delete command------------------------------------------------

 -- delete Quetions
 create  proc deleteQuetion @id int
 as
 begin try
   delete 
   from Questions
   where Q_id=@id
   end try
   begin catch
		select 'QueryError, Nothing Has Executed'
   end catch
   Go

--================================================ Exam Table======================================================
-----------------------------------insert command------------------------------------------------

-- insert command
create proc insertExam (@ExamDuration int , @ExamStartDate datetime ,@courseID int)
as
   begin try
   insert into Exam
   Values(@ExamDuration,@ExamStartDate,@courseID)
   end try
   begin catch
		select 'QueryError, Nothing Has Executed'
   end catch
  Go


	
-----------------------------------select command------------------------------------------------

 --select command  here we select ExamQuetions for specific course
 create proc selectExamQuetions @crsId int
 as 
	begin try
    select Exam_id as [Exam Number]  ,Q_desc as QuestionBody,Q_grade as grade
	from Exam e ,Questions q,Courses c
	where c.Crs_id=e.Crs_id and c.Crs_id=q.Crs_id and c.Crs_id=@crsId
	end try
	begin catch
			select 'QueryError, Nothing Has Executed'
	end catch
 Go
 ----------------------------------- update command------------------------------------------------

 --update command

create proc updateExam @id int,@newData int
 as 
 begin try
    update Exam
	set Exam_Duration=@newData 
	where Exam_id=@id
 end try
 begin catch
			select 'QueryError, Nothing Has Executed'
 end catch
 Go
 
 
 ----------------------------------- delete command------------------------------------------------

 --delete command
create proc deleteExam @id int
 as 
 begin try
    delete Exam
	where Exam_id=@id
 end try
 begin catch
			select 'QueryError, Nothing Has Executed'
 end catch
 Go
--================================================ Topic Table======================================================

 ----------------------------------- insert command------------------------------------------------

-- insert command
create proc insertTopic (@TopicName Varchar(20) , @courseId int)
as
  begin try
   insert into Topics
   Values(@TopicName,@courseId)
  end try
  begin catch
			select 'QueryError, Nothing Has Executed'
  end catch

  Go

 ----------------------------------- select command------------------------------------------------

 --select command   we select all topics Associated with specific course
 create proc selectTopic @course_id int
 as 
    begin try

    select Topic_name from Topics
	where Crs_id=@course_id
	end try
	begin catch
			select 'QueryError, Nothing Has Executed'
    end catch
Go
 ----------------------------------- update command------------------------------------------------

 
 --update command
 create proc updateTopic @id int,@newData varchar(20)
 as 
    begin try
    update Topics
	set Topic_name=@newData
	where Topic_id=@id
	end try
	begin catch
			select 'QueryError, Nothing Has Executed'
    end catch

 Go
 ----------------------------------- delete command------------------------------------------------

 --delete command
 create proc deleteTopic @topicId int
 as 

 begin try
    delete Topics
	where Topic_id=@topicId
end try
begin catch
			select 'QueryError, Nothing Has Executed'
    end catch
--================================================ Q_choises Table======================================================
Go
 ----------------------------------- insert command------------------------------------------------
create proc insertQuestionChoooes (@chooes varchar(10) , @QuestionsId int)
as
  begin try
   insert into Q_Choices
   Values(@chooes, @QuestionsId)
  end try
  begin catch
		select 'QueryError, Nothing Has Executed'
  end catch

   ----------------------------------- select command------------------------------------------------
   Go

 --select command
 create proc selectChoices @QuestionID int
 as 
  begin try
    select choice from Q_Choices
	where Q_id=@QuestionID 
  end try
  begin catch
		select 'QueryError, Nothing Has Executed'
  end catch

   Go
  -----------------------------------update command------------------------------------------------
  -- here i can update only first choice
alter proc updateChoices @QuestionID int,@newchoice varchar(20)
 as 
  begin try
	update Q_Choices
	set choice=@newchoice
	where Q_id=@QuestionID and choice=(select top(1) choice from Q_Choices where  Q_id=@QuestionID)
  end try
  begin catch
		select 'QueryError, Nothing Has Executed'
  end catch
  
 
   -----------------------------------delete command------------------------------------------------

 --delete command
create proc deleteChoices @QuestionID int
 as 
 begin try
    delete Q_Choices
	where Q_id=@QuestionID
end try
 begin catch
		select 'QueryError, Nothing Has Executed'
  end catch
 Go

 --================================================ studentAnswer Table======================================================

    -----------------------------------insert command------------------------------------------------

 create proc insertStudentAnswer (@studentAnswer varchar(50),@QID int ,@SID int, @EID int )
as

   begin try
   insert into St_Answer
   Values(@studentAnswer,@QID,@SID, @EID)
   end try

   begin catch
		select 'QueryError, Nothing Has Executed'
   end catch


   Go

      -----------------------------------select command------------------------------------------------
create proc selectStudentAnswer @st_id int,@Exam_id int 
as
	begin try
		select Q_desc as Question,st_ans as Student_Answer
		from Questions as q,St_Answer as sAns
		where q.Q_id= sAns.Q_id and sAns.St_id=@st_id  and sAns.Exam_id=@Exam_id
	end try
	begin catch
			select 'QueryError, Nothing Has Executed'
	end catch

 -----------------------------------update command------------------------------------------------
 GO
 create proc updateStudentAnswer (@newstudentAnswer varchar(50),@QID int ,@SID int, @EID int )
as

   begin try
   update St_Answer
   set st_ans=@newstudentAnswer
   where Q_id=@QID and st_id=@SID and Exam_id=@EID
   end try

   begin catch
		select 'QueryError, Nothing Has Executed'
   end catch
   
  -----------------------------------delete command------------------------------------------------
  Go
 create proc deleteStudentAnswer (@QID int ,@SID int, @EID int )
as

   begin try
   delete St_Answer
   where Q_id=@QID and st_id=@SID and Exam_id=@EID
   end try

   begin catch
		select 'QueryError, Nothing Has Executed'
   end catch
  
 --////////////////////////////////////////////////////////////////////////////////////
 --================================Reporting-----------------------------------------
 --============================================================================
--============================================================================Report-1


create proc getStudentsByDeptId @deptID int
as 
	begin try
		select concat(StF_Name,' ',StL_Name),St_Address,St_Age,St_National_id
		from Student
		where Dept_id=@deptID
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch
	

--================================================Report-2
create proc getStudentGrades @stdId int
as
	begin try
		select Crs_name ,stcr.Crs_grade from Courses as cr, St_Crs as stCr
		where stCr.Crs_id=cr.Crs_id
		and
		stCr.St_id=@stdId
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

	

-----======================================= Report-3
create proc getCourseStudentInfo @id int
as
	begin try
	 SELECT main.FullName , main.Q_courses,count(Main.[student Number]) as[student Number]
		FROM
			(
				SELECT DISTINCT concat(insF_Name,insL_name) as FullName, s.st_id as [student Number],
					(
						select c.Crs_name + ',' as [text()]
						from instructor i ,Courses c, Ins_Crs ic1
						where  i.ins_id=ic1.ins_id and c.crs_id=ic1.crs_id --and ic1.ins_id=ic2.ins_id
						order by concat(insF_Name,insL_name) 
						FOR XML PATH (''), TYPE
					).value('text()[1]','nvarchar(max)') [Q_courses]
				from  instructor i ,student s,Std_Ins si,Ins_Crs ic2,Courses c
				where   i.ins_id=ic2.ins_id and c.crs_id=ic2.crs_id and i.ins_id=si.Ins_id and s.St_id=si.St_id
				and i.Ins_id=@id
				)  main
				group by main.FullName , main.Q_courses
	end try
	begin catch
		select 'QueryError, Nothing Has Executed'
	end catch

	
 GO
-----======================================= Report-4

create proc selectTopic @course_id int
 as 
    begin try

    select Topic_name from Topics
	where Crs_id=@course_id
	end try
	begin catch
    end catch
Go

-----======================================= Report-5
GO

alter proc selectExamQuetions @examId int
as
 SELECT main.Q_desc,main.Q_choices
FROM
    (
        SELECT DISTINCT q.Q_desc, 
            (
                select Qch1.Choice + ',' as [text()]
                from Questions q ,Q_Choices Qch1
			    where q.Q_id=Qch1.Q_id and Qch1.Q_id=Qch2.Q_id
				order by  q.Q_desc
                FOR XML PATH (''), TYPE
            ).value('text()[1]','nvarchar(max)') [Q_Choices]
        from Questions q ,Q_Choices Qch2,Exam e ,Courses c
		where c.Crs_id=e.Crs_id and q.Q_id=Qch2.Q_id and c.Crs_id=q.Crs_id and e.Exam_id =@examId
    )  main
	
 GO
 --////////////////////////////////////////////////////////////////////////////////////
-----======================================= Report-6
 create proc selectStudentAnswer @st_id int,@Exam_id int 
as
	begin try
		select Q_desc as Question,st_ans as Student_Answer
		from Questions as q,St_Answer as sAns
		where q.Q_id= sAns.Q_id and sAns.St_id=@st_id  and sAns.Exam_id=@Exam_id
	end try
	begin catch
			select 'QueryError, Nothing Has Executed'
	end catch

	--///////////////////////////////////////////////////Generate Exam///////////////////////////////////////////////////////
GO

 alter proc GenerateExam @CourseId int
as
 SELECT Exam_id,Q_id,main.Q_desc,main.Q_choices,newid()
FROM
    (
        SELECT DISTINCT Exam_id,q.Q_id, q.Q_desc, 
            (
                select Qch1.Choice + ',' as [text()]
                from Questions q ,Q_Choices Qch1
			    where q.Q_id=Qch1.Q_id and Qch1.Q_id=Qch2.Q_id
				order by  q.Q_desc
                FOR XML PATH (''), TYPE
            ).value('text()[1]','nvarchar(max)') [Q_Choices]
        from Questions q ,Q_Choices Qch2,Exam e ,Courses c
		where c.Crs_id=e.Crs_id and q.Q_id=Qch2.Q_id and c.Crs_id=q.Crs_id and e.crs_id =@CourseId
		
    )  main
	order by newid()

--====================================================Exam Answer==================================================
Go
alter proc ExamAnswer 
as
  select Q_desc,Q_model_answer
  from questions q ,st_Answer SA
  where SA.Q_id=q.Q_id
Go
--==================================================== student crs update==================================================
create PROC [dbo].[UpdateStudentCourse] 
@student_id int, 
@crs_id int, 
@grade int 
AS 
BEGIN 
 UPDATE St_Crs 
 SET Crs_grade = @grade  
 WHERE St_id = @student_id and Crs_id = @crs_id 
END

--====================================================Exam correction==================================================
ALTER proc [dbo].[ExamCorrection] @studentId int,@courseID int
as
begin
	declare @ExamId int =(select Exam_id from Exam where Crs_id=@courseID)
	declare @grade int = (select sum(t.Q_grade) from (select Q_desc,Q_model_answer,Q_grade,St_ans,SA.Q_id,SA.St_id,SA.Exam_id
		from Questions q,St_Answer SA
		where SA.Q_id=q.Q_id) as t
		where t.Q_model_answer =t.St_ans  and t.St_id=@studentId)

	execute [UpdateStudentCourse] @studentId, @courseID, @grade
end




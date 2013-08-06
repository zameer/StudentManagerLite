var StudentModel = function () {
    var self = this;
    //Progress indicator, while loading... list of students
    self.loading = ko.observable(true);
    //Dynamic change of template, Default: 'read-template'
    self.displayMode = function (student) {
        return student.Edit() ? 'edit-template' : 'read-template';
    };

    //Init array to hold list of object
    self.Students = ko.observableArray();

    //Gets list of students
    $.getJSON('api/Students', function (data) {
        self.Students(ko.utils.arrayMap(data, function (student) {
            var objStudent = {
                StudentId: student.StudentId,
                StudentName: ko.observable(student.StudentName),
                Edit: ko.observable(false)
            }
            return objStudent;
        }));
        self.loading(false);
    });

    //Enable edit mode
    self.edit = function (student) { student.Edit(true) };

    //Update/Patch modified student
    self.Patch = function (student) {
        $.ajax({ type: "PUT", url: 'api/Students/' + student.StudentId, data: student })
                .done(function () {
                    student.Edit(false);
                });
    };

    //DELETE selected student
    self.Remove = function (student) {
        if (confirm('Are you sure you want to delete this ' + student.StudentName() + '?')) {
            $.ajax({ type: "DELETE", url: 'api/Students/' + student.StudentId })
                   .done(function () {
                       self.Students.remove(student);
                   });
        };
    };
};

$(function () {
    ko.applyBindings(new StudentModel);
});
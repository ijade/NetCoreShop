﻿namespace MVC_Sample;

public record class StudentListViewModel
(
    IEnumerable<StudentListItemViewModel> Students
);
public record class StudentListItemViewModel
(
    int Id,
    string Name,
    int ClassCount
);
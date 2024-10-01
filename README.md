I am attempting to reproduce and test two bugs / unexpected behaviors:
- A) Binding multiple controls to the same value in a VM overrides the default value with one from the pool of controls, even if only 1 control is enabled and visible. NB: Not sure how it bases itself on which to use.
- B) Some (1?) machines (experienced on W11 so far) have extreme lag when using the same value on multiple controls

| Issue  | Reproducible | Reproduction Notes | Steps | Expected | Actual |
| ------------- | ------------- | ------------- | ------------- | ------------- | ------------- |
| A  | Yes  | Able to reproduce on all machines | 1. Click "Start"<br>2.Select the TextBox in the Text column<br>3.Ctrl+A highlight all the content<br>4.Backspace (forces a default value) | Empty box | DateTimeOffset default
| B  | Sometimes  | Consistently reproduces on (1) known machine so far<sup>* | 1. Type in the text box | Fast response | (*) Extremely slow and laggy

> \* Reproducable by [Chase](https://github.com/ChaseDRedmon).<br>
> I need to confirm if anyone else experiences this, if isolated need to figure out the issue and address it.

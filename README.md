I am attempting to reproduce and test two bugs / unexpected behaviors:
- A) Binding multiple controls to the same value in a VM overrides the default value with one from the pool of controls, even if only 1 control is enabled and visible. NB: Not sure how it bases itself on which to use.
- B) Some machines (experienced on W11 so far) have extreme lag when using the same value on multiple controls

| Issue  | Reproducible | Reproduction Info |
| ------------- | ------------- | ------------- |
| A  | Yes  | Able to reproduce on all machines |
| B  | Sometimes  | Consistently reproduces on (1) known machine so far<sup>* ||

> \* Reproducable by [Chase](https://github.com/ChaseDRedmon).<br>
> I need to confirm if anyone else experiences this, if isolated need to figure out the issue and address it.

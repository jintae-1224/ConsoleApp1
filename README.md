# ConsoleApp1

2021-06-22


# projects

## parset to do

첫번째 섹션(issue 관련)

![image](https://user-images.githubusercontent.com/83216197/122852759-1cdaab00-d34c-11eb-8225-94cf479e41f3.png)


1. newly added : 이 프로젝트에 추가된 이슈를 만들면, 해당 이슈는 자도으로 todo에 들어가게 해주는 설정.

            issue를 만들면 자동으로 project에 추가
            
2. Reopend : close 된 이슈가 이 프로젝트에서 reopen되었을 시, 자동으로 to do 쪽으로 옮겨지게 되는 설정.
            
            issue가 clsoe 된 상태에서 reopen isuue를 하면 done에 있던 issue가 to do 쪽으로 옮겨짐   


두번째 섹션(pr)관련

![image](https://user-images.githubusercontent.com/83216197/122854084-27963f80-d34e-11eb-8b75-9b5ae1f1c5e8.png)

1. newly added : 이 프로젝트에 추가된 pull request가 생성되면, 자동으로 to do에 추가하는 설정

![image](https://user-images.githubusercontent.com/83216197/122856772-57dfdd00-d352-11eb-943c-07b18d22d649.png)

            to do에 추가됨

2. reopend : 이 프로젝트에 추가되었고, close된 pr이 다시 열리면 to do에 추가하겠다는 설정


## preset : In progress

첫번째 섹션(issue 관련)

![image](https://user-images.githubusercontent.com/83216197/122861752-e9ebe380-d35a-11eb-959e-890908f3837d.png)

1. reopened : to do의 reopend 설정이랑 같음.


두번째 섹션(pr관련)

![image](https://user-images.githubusercontent.com/83216197/122861843-1a338200-d35b-11eb-84d3-36f98c2cac0a.png)

1. newly added, reopened : to do와 같음.

2. approved by reviewer : pr이 최소 필수 approving review를 받으면 자동으로 이 column으로 이동(pending approval by reviewer가 솰성화 된 경우 권장)

3. pending approval by reviewer : 리뷰어가 request changes를 하거나, 필요한 최소 승인 수를 충족하지 못할 때 자동으로 이 column 으로 이동.


## preset : Done

첫번째 섹션(issue 관련)

![image](https://user-images.githubusercontent.com/83216197/122862300-e016b000-d35b-11eb-9be6-e2c03a217c04.png)

1. closed : 프로젝트에 추가된 이슈가 close되면 자동으로 done으로 옮겨질지 결정하는 설정


두번째 섹션(pr관련)

![image](https://user-images.githubusercontent.com/83216197/122862455-210ec480-d35c-11eb-808c-edde874910c2.png)

1. merged : pr이 merge되면 자동으로 Done으로 옮겨주는 설정

2. closed with unmerged commits : pr이 merge되지 않은 채 닫히면 자동으로 Done으로 옮겨주는 



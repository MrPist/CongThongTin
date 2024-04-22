use CongThongTinMobifone

-- Dữ liệu bảng dạng số điện thoại (Number_Type)
INSERT INTO Number_Type(Number_TypeID,Title, Content, cost) VALUES(N'NT001',N'Sim Phong Thủy',N'Những con số mang giá trị tương trợ cho những cung mệnh hữu.','240.000vnd');
INSERT INTO Number_Type(Number_TypeID,Title,Content, cost) VALUES(N'NT002',N'Sim Tài Lộc',N' Đặc điểm là số cuối hoặc cặp trùng lặp mang giá ý nghĩa may mắn, thu hút tài lộc cho người sở hữu','300.000vnd');
INSERT INTO Number_Type(Number_TypeID,Title,Content, cost) VALUES(N'NT003',N'Sim thần tài',N'Một loại sim được mọi người săn lùng và càng trở nên hiếm. Với các số cuối hoặc cặp trùng lặp là 39 - thần tài nhỏ hoặc 79 - thần tài lớn','400.000vnd');
INSERT INTO Number_Type(Number_TypeID,Title,Content, cost) VALUES(N'NT004',N'Sim lặp',N'--AABBCC, ABABAB-- Một dãy số vô cùng khang hiếm do số lượng đã ít mà còn được giới sành sỏi đánh giá rất cao và sẵn sàng trả phí cao để sở hữu.','150.000vnd');
INSERT INTO Number_Type(Number_TypeID,Title,Content, cost) VALUES(N'NT005',N'Sim tiến đều',N'--ABCDE-- Sảnh tiến. Loại sim này đã thành công trong việc thuyết phục những người dùng khó tính đến đâu cũng phải siêu lòng.','240.000vnd');
INSERT INTO Number_Type(Number_TypeID,Title,Content, cost) VALUES(N'NT006',N'Sim tứ quý',N'--AAAA-- Một loại sim mà chỉ cần xuất hiện thôi thì chi phí để sở hữu đã không còn là vấn đề nữa','350.000vnd');
INSERT INTO Number_Type(Number_TypeID,Title,Content, cost) VALUES(N'NT007',N'Sim thường',N'Sim sô bình thường','60.000vnd');
delete from Number_Type where Number_TypeID = 'NT003'
select * from Number_Type

-- Dữ liệu bảng Loại bài đăng (Post_Cate)
INSERT INTO Post_cate (PostCateID,Name, Description) VALUES (N'PCT1',N'Trang tin tức',N'Tổng hợp các bài viết, tin tức của website.');
INSERT INTO Post_cate(PostCateID,Name,Description) VALUES (N'PCT2',N'Trang gói cước',N'Bao gồm các thông tin về gói cước data cũng như là cước gọi.');
INSERT INTO Post_cate(PostCateID,Name,Description) VALUES (N'PCT3',N'Trang sim số',N'Nơi tổng hợp các loại sim số với đa dạng hình thức cho người dùng lựa chọn.');
select * from Post_cate

-- Dữ liệu bảng số điện thoại (Phone_number)
INSERT INTO Phone_number(Number, Number_TypeID, PostCateID, description, link) VALUES(N'0782419595',N'NT004',N'PCT3',N'Sim lặp 4 số đuôi là 9595','https://chonso.mobifone.vn/sim-so/thong-tin-sim?msisdn=0782419595');
INSERT INTO Phone_number(Number, Number_TypeID, PostCateID, description, link) VALUES(N'0768237997',N'NT003',N'PCT3',N'Với phong cách đảo số nhưng lại mang số may mắn là số thần tài lớn 79','https://chonso.mobifone.vn/sim-so/thong-tin-sim?msisdn=0768237997');
select * from Phone_number
-- Dữ liệu bảng loại gói cước (Package_Cate)
INSERT INTO Package_Cate (Package_CateID, Package_name) VALUES (N'G01',N'Gói cước gọi');
INSERT INTO Package_Cate (Package_CateID, Package_name) VALUES (N'G02',N'Gói cước data');
select * from Package_Cate

-- Dữ liệu bảng gói cước (Package)
INSERT INTO Package (Package_ID, Package_title, Package_content, Package_CateID, PostCateID, cost, link) VALUES (N'MFY',N'DK MFY 0799980067 GỬI 909',
N'200GB/30 ngày. 
Miễn phí truy cập FACEBOOK, YOUTUBE.
Dùng chung cho nhóm tối đa 5 thành viên.',N'G02',N'PCT2','200.000 vnd', N'https://congtacvien.mobifone.vn/goi-cuoc-uu-dai/chi-tiet-goi-cuoc-MFY?rf=925ZXJ');
INSERT INTO Package (Package_ID, Package_title, Package_content, Package_CateID, PostCateID, cost, link) VALUES (N'MXH100',N'30GB/30 ngày',N'1GB data tốc độ cao/ngày.
Miễn phí truy cập Facebook, Youtube, Tiktok.',N'G02',N'PCT2','100.000 vnd', N'https://congtacvien.mobifone.vn/goi-cuoc-uu-dai/chi-tiet-goi-cuoc-MXH100?rf=925ZXJ');
select * from Package
-- Dữ liệu bảng trang tin (Post)
INSERT INTO Post (PostID, Post_title, Post_content, PostCateID, Date_created, Date_update, avatar) VALUES (N'P001',N'Mình cùng đón Giáp Thìn - 2024',N'Từ ngày 12/12/2023 đến ngày 31/01/2024, MobiFone Tỉnh An Giang triển khai chương trình khuyến mại “Mình cùng đón Giáp Thìn – 2024!” Khách hàng hòa mạng mới hoặc đăng ký mới/gia hạn bất kỳ gói cước Data nào của MobiFone trong thời gian diễn ra chương trình .

																															Chào đón Năm Mới Giáp Thìn 2024, MobiFone An Giang triển khai chương trình khuyến mại “Mình Cùng Đón Giáp Thìn 2024! ” từ ngày 12/12/2023 đến 31/01/2024 Khách hàng hòa mạng mới hoặc đăng ký mới/gia hạn bất kỳ gói cước Data nào của MobiFone trong thời gian diễn ra chương trình, như một lời chúc, một lời tri ân sâu sắc dành cho các khách hàng đã luôn tin yêu và đồng hành cùng MobiFone Tỉnh An Giang.

																															Theo đó, từ ngày từ ngày 12/12/2023 đến 31/01/2024, Khách hàng hòa mạng mới hoặc đăng ký mới/gia hạn bất kỳ gói cước data nào của MobiFone trong thời gian diễn ra chương trình có nhắn tin sms tới số thuê bao 0779249999 kèm số dự đoán gần đúng nhất của 03 số cuối kết quả Giải đặc biệt Xổ số Kiến thiết tỉnh An Giang xổ ngày 01/02/2024.

																															Ví dụ: Thuê bao phát triển mới ngày 15/12/2023 soạn tin nhắn: 678 gởi đến 0779249999.

																															Sau khi nhắn tin tham gia chương trình thành công, khách hàng sẽ nhận lại được tin nhắn xác nhận đã đăng ký thành công – chậm nhất ngày n+1
																															Mỗi khách hàng chỉ được tham dự 01 mã dự thưởng cho 1 số thuê bao (gồm thuê bao trả trước hoặc thuê bao trả sau)
																															Kết quả trúng thưởng được căn cứ vào dự đoán của khách hàng có số gần đúng với 03 số cuối (trường hợp giống kết quả sẽ xét thời gian sớm hơn) của Giải đặc biết Xổ số Kiến thiết tỉnh An Giang ngày 01/02/2024
																															Giải thưởng:
																																1 giải nhất: 1 chỉ vàng 9999.
																																20 giải nhì: thẻ cào mệnh giá 100.000đ.
																																24 giải ba: thẻ cào mệnh giá 50.000đ.
																																100 giải khuyến khích: 1 hộp khẩu trang y tế.'
,N'PCT1','03/20/2024','03/20/2024','GIAPTHINH_2.jpg');
INSERT INTO Post (PostID, Post_title, PostCateID, Post_content, Date_created, Date_update, avatar) VALUES (N'P002',N'Trọn gói Data - Thả ga gom quà',N'PCT1',N'<p>Trong tháng 3 này, MyPoint triển khai siêu khuyến mại: tích ngay 5% giá trị gói cước, nhận phiếu quà tặng tới 50K khi đăng ký tại MyPoint. 
Tiếp nối các chương trình khuyến mại đặc sắc từ tháng 2, MyPoint tiếp tục triển khai chương trình tích điểm gói cước và tặng phiếu giảm giá Shopee, Bách Hóa Xanh cho khách hàng đăng ký gói cước trên MyPoint - Ứng dụng tích điểm đổi quà do MobiFone đồng sáng lập.</p><p>Theo đó, đẩy thêm những giá trị gia tăng cho dịch vụ viễn thông, MobiFone triển khai các chương trình khuyến mại gói cước thường xuyên hàng tháng. Trong tháng 3, khách hàng mua gói cước trên ứng dụng MyPoint sẽ được nhận ưu đãi: Tích 5% điểm MyPoint trên giá trị gói cước MXH120, KC90, PT70, V90. Tặng 30.000Đ - 50.000Đ Voucher Shopee/ Bách Hóa Xanh cho khách hàng may mắn khi đăng ký bất kỳ gói cước dài hạn trên MyPoint.</p>
<p>Điểm MyPoint có thể được sử dụng linh hoạt để đổi dùng như tiền mặt cho các dịch vụ viễn thông hoặc voucher giảm giá triền trực tiếp trên hóa đơn từ hơn 300 thương hiệu đối tác (1 điểm MyPoint = 1 VNĐ). Ngoài ra, khách hàng có thể dễ dàng tích lũy điểm MyPoint từ việc nạp thẻ, mua sắm online.</p><p class="text-danger"><strong>Chương trình áp dụng từ ngày 14/03 - 25/03/2024.</strong>
</p><p><strong>Hình thức đăng ký gói cước:</strong> PTE [khoảng cách] TÊN GÓI CƯỚC gửi 9084.</p><p> Ví dụ: Đăng ký gói cước KC90, soạn cú pháp: PTE KC90 gửi 9084.</p>',N'04/05/2024',N'',N'Trọn gói Data - Thả ga gom quà.png');
INSERT INTO Post (PostID, Post_title, PostCateID, Post_content, Date_created, Date_update, avatar) VALUES (N'P003',N'Sinh nhật linh đình, giảm siêu hậu hĩnh',N'PCT1',
N'<p><em>Nhân dịp sinh nhật tuổi 31, MobiFone tung deal giảm tới 50% giá gói D24 trong 3 chu kỳ đầu tiên cho tất cả khách hàng.</em></p><p><span>Trong bối cảnh công nghệ phát triển, thiếu đi Internet thực sự là nỗi lo đối với nhiều người, đặc biệt là những tín đồ <em>"ăn - ngủ - nghỉ"</em> với mạng xã hội. Tuy vậy, Internet không phải miễn phí ở khắp mọi nơi, và người dùng muốn truy cập mạng hẳn sẽ tìm đến gói cước data ngắn ngày để đáp ứng nhu cầu.</span></p><p>Điểm MyPoint có giá trị quy đổi khi khách hàng mua sắm, nạp thẻ điện thoại, đổi ưu đãi hoặc voucher hot, với mỗi điểm tương đương với 1 đồng.</p><p><img width="200px" src="https://api.mobifone.vn/images/notifications/1713260931854_D24.jpg" /></p><p> Cụ thể, khách hàng trả trước, trả sau khi đăng kí gói D24 sẽ nhận ngay ưu đãi giảm 50% giá gói, chỉ còn 10.000 đồng/ 24GB/ ngày trong 3 chu kỳ sử dụng đầu tiên (đăng kí mới + 2 chu kỳ gia hạn tiếp theo). Từ chu kỳ thứ 4, khách hàng gia hạn sẽ áp dụng nguyên giá gói 20.000 đồng/24 GB/ngày.</p><p class="text-danger"><strong>Chương trình ưu đãi kéo dài từ 16/4/2024 đến hết 31/7/2024.</strong></p><p class="text-danger"><em>Chương trình áp dụng khi thuê bao đăng ký gói cước trực tiếp từ MobiFone (qua SMS, My MobiFone, mobifone.vn); không áp dụng cho kênh Đại lý (mSocial, VAS online); không áp dụng chi trả chi phí bán gói lần đầu đối với chương trình ưu đãi này.</em></p>',
N'04/10/2024',N'',N'sinhnhat31.jpg');
select * from Post


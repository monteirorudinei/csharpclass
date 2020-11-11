class User
{
    private date createDate;

    public int UserID { get; set; }
    public string Name { get; set; }
    public date CreateDate { get => createDate; set => createDate = value; }
}

[HttpPost("delete/{id}")]
public IActionResult Delete(uint id) {
  User user = _context.Users.FirstOrDefault(user => user.Id == id);
  if (user == null)
    return NotFound();
  _context.Users.Remove(user);
  _context.SaveChanges();
  Debug.WriteLine($"The user with Login={user.Login} has been deleted.");
  return Ok();
}
